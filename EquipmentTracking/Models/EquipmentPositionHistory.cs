using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EquipmentTracking.Models;

public class EquipmentPositionHistory
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Equipment")]
    public int EquipmentId { get; set; }

    public Equipment? Equipment { get; set; }

    public DateTime Date { get; set; }

    public double Lat { get; set; }

    public double Lon { get; set; }
}
