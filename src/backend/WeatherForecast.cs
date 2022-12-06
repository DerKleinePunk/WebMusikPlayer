using System.ComponentModel.DataAnnotations;

namespace MusikPlayerBackend;

/// <summary>
/// The Weather Forecast Data
/// </summary>
public class WeatherForecast
{
    [Required]
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
