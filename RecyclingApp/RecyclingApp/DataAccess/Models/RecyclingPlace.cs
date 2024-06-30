using System.ComponentModel.DataAnnotations;

namespace RecyclingApp.DataAccess.Models;

public class RecyclingPlace
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Name { get; set; }

    public double Longitude { get; set; }

    public double Latitude { get; set; }
}