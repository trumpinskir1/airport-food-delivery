using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RestaurantsController : ControllerBase
{
    private readonly RestaurantService _restaurantService;

    public RestaurantsController(RestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Restaurant>>> Get()
    {
        var restaurants = await _restaurantService.GetAsync();

        return Ok(restaurants);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Restaurant>> Get(string id)
    {
        var restaurant = await _restaurantService.GetAsync(id);

        if (restaurant is null)
        {
            return NotFound();
        }

        return Ok(restaurant);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Restaurant restaurant)
    {
        await _restaurantService.CreateAsync(restaurant);

        return CreatedAtAction(
            nameof(Get),
            new { id = restaurant.Id },
            restaurant);
    }
}