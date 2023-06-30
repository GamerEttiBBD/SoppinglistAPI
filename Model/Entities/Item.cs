using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities; 

[Table("ITEMS")]
public class Item {

    [Column("ITEM_ID")]
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Column("ITEM_NAME")]
    [Required, StringLength(45)]
    public string Name { get; set; } = null!;
}