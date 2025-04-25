using Library.ApplicationCore;
using Library.ApplicationCore.Entities;

namespace Library.Infrastructure.Data;

public class JsonPatronRepository : IPatronRepository
{
    private readonly JsonData _jsonData;

    public JsonPatronRepository(JsonData jsonData)
    {
        _jsonData = jsonData;
    }

    public async Task<List<Patron>> SearchPatrons(string searchInput)
    {
        await _jsonData.EnsureDataLoaded();

        var searchResults = _jsonData.Patrons!
          .Where(patron => patron.Name.Contains(searchInput))
          .OrderBy(patron => patron.Name)
          .ToList();

        searchResults = _jsonData.GetPopulatedPatrons(searchResults);

        return searchResults;
    }

    public async Task<Patron?> GetPatron(int id)
    {
        await _jsonData.EnsureDataLoaded();

        return _jsonData.Patrons!
          .Where(patron => patron.Id == id)
          .Select(patron => _jsonData.GetPopulatedPatron(patron))
          .FirstOrDefault();
    }

    public async Task UpdatePatron(Patron patron)
    {
        await _jsonData.EnsureDataLoaded();
        var patrons = _jsonData.Patrons!;
        var existingPatron = patrons.FirstOrDefault(p => p.Id == patron.Id);

        if (existingPatron != null)
        {
            var index = patrons.IndexOf(existingPatron);
            patrons[index] = patron;
            await _jsonData.SavePatrons(patrons);
            await _jsonData.LoadData();
        }
    }
}
