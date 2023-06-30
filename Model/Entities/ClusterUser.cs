using System.Reflection.Metadata.Ecma335;

namespace Model.Entities;

[Table("CLUSTER_has_USER")]
public class ClusterUser
{
    public Cluster Cluster { get; set; } = null!;
    
    [Column("CLUSTER_ID")]
    [Required]
    public int ClusterId { get; set; }
    
    public User User { get; set; }
    
    [Column("USER_ID")]
    [Required]
    public int UserId { get; set; }
}