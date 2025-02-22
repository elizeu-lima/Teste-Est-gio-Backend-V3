using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EquipmentTracking.Models;

public class Equipment
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [ForeignKey("EquipmentModel")]
    public int EquipmentModelId { get; set; }

    public EquipmentModel? EquipmentModel { get; set; }
}
