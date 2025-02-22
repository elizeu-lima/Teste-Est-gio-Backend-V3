using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EquipmentTracking.Models;

public class EquipmentStateHistory
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Equipment")]
    public int EquipmentId { get; set; }

    public Equipment? Equipment { get; set; }

    [ForeignKey("EquipmentState")]
    public int EquipmentStateId { get; set; }

    public EquipmentState? EquipmentState { get; set; }

    public DateTime Date { get; set; }
}
