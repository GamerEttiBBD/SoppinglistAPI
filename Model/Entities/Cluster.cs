using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities; 

[Table("CLUSTERS")]
public class Cluster {
    
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("CLUSTER_ID")]
    public int Id { get; set; }

    [Column("CLUSTER_NAME")]
    [Required, StringLength(45)]
    public string Name { get; set; } = null!;
}