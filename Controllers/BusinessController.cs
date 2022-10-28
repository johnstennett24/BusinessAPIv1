using BusinessAPI.Models;
using BusinessAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BusinessAPI.Controllers;

[ApiController]
[Route("businesses")]
public class BusinessController : ControllerBase
{
  [HttpGet]
  public ActionResult<List<Business>> GetAll() => BusinessServices.GetAll;

  [HttpGet("{id}")]
  public ActionResult<Business> Get(int id)
  {
    var business = BusinessServices.Get(id);

    if (business is null)
    {
      return NotFound(); 
    }
    return business;
  }

  [HttpPost]
  public IActionResult Create(Business business)
  {
    BusinessServices.Add(business);
    return CreatedAtAction(nameof(Create), new { id = business.Id }, business);
  }

  [HttpPut("{id}")]
  public IActionResult Update(int id, Business business)
  {
    if (id != business.Id)
    {
      return BadRequest();
    }

    var existingBusiness = BusinessServices.Get(id);
    if (existingBusiness is null)
    {
      return NotFound();
    }
    
    BusinessServices.Update(business);

    return NoContent();
  }

  [HttpDelete("{id}")]
  public IActionResult Delete(int id)
  {
    var business = BusinessServices.Get(id);

    if (business is null)
    {
      return NotFound();
    }
    
    BusinessServices.Delete(id);
    return NoContent();
  }
  
  

}