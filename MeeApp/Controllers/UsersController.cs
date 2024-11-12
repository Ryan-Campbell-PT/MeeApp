using Microsoft.AspNetCore.Mvc;
using StarterFlutterApp.Models;

namespace StarterFlutterApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly ApiDbContext _context;

    public UsersController(ApiDbContext context)
    {
        _context = context;
    }
}