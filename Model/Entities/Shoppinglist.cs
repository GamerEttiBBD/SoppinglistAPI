using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities; 

[Table("SHOPPINGLISTS")]
public class ShoppingList {
    
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("SHOPPINGLIST_ID")]
    public int Id { get; set; }

    [Column("SHOPPINGLIST_NAME")]
    [Required, StringLength(45)]
    public string Name { get; set; } = null!;
}