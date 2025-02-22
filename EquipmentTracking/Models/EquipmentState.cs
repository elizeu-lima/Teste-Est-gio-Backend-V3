using System.ComponentModel.DataAnnotations;

namespace EquipmentTracking.Models;

public class EquipmentState
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string Color { get; set; } = string.Empty;
}
