using System.ComponentModel.DataAnnotations;

namespace EquipmentTracking.Models;

public class EquipmentModel
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;
}
