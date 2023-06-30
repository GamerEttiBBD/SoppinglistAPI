namespace Model.Entities;

[Table("SHOPPINGLIST_has_ITEMS")]
public class ShoppingListItems
{
    public Item Item { get; set; } = null!;
    
    [Column("ITEM_ID")]
    [Required]
    public int ItemId { get; set; }
    
    public User User { get; set; } = null!;
    
    [Column("USER_ID")]
    [Required]
    public int UserId { get; set; }
    
    public ShoppingList ShoppingList { get; set; } = null!;
    
    [Column("LIST_ID")]
    [Required]
    public int ListId { get; set; }
    
    [Column("AMOUNT")]
    [Required]
    public int Amount { get; set; }
    
    [Column("ADDED_AT")]
    [Required]
    public DateTime AddedAt { get; set; }
    
    [Column("REQUIRED_BY")]
    public DateTime RequiredBy { get; set; }
}