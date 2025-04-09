using System.ComponentModel.DataAnnotations;
using ClimateMonitor.Services.Validation;

namespace ClimateMonitor.Services.Models;

public class DeviceReadingRequest
{
    [Required]
    [FirmwareAttribute]
    public string FirmwareVersion { get; set; } = string.Empty;

    [Required]
    public decimal Temperature { get; set; }

    [Required]
    public decimal Humidity { get; set; }
}
