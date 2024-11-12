using System.ComponentModel.DataAnnotations;

namespace StarterFlutterApp.Models;

public class Users
{
    [Key]
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}