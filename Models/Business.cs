using Microsoft.AspNetCore.Components;

namespace BusinessAPI.Models;

public class Business
{
  public int Id { get; set; }
  
  public string BusinessName { get; set; }
  
  public float Revenue { get; set; }
}