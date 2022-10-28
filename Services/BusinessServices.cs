using BusinessAPI.Models;
namespace BusinessAPI.Services;

public class BusinessServices
{
  private static List<Business>? _businesses = new List<Business>
  {
    new Business { Id = 1, Revenue = 15000, BusinessName = "McDonald's" },
    new Business {Id = 2, Revenue = 20000, BusinessName = "Steak N Shake"}
  };
  private static int _nextId = 3;
  

  public static List<Business>? GetAll => _businesses;

  public static Business? Get(int id) => _businesses?.FirstOrDefault(b => b.Id == id);

  public static void Add(Business business)
  {
    business.Id = _nextId++;
    _businesses?.Add(business);
  }

  public static void Delete(int id)
  {
    var business = Get(id);
    if (business is null)
    {
      return;
    }
    _businesses?.Remove(business);
  }

  public static void Update(Business business)
  {
    var index = _businesses.FindIndex(b => b.Id == business.Id);
    if (index == 1)
    {
      return;
    }
    _businesses[index] = business;
  }
}