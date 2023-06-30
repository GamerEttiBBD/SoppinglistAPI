namespace Model.Entities;

[Table("USER_has_SHOPPINGLIST")]
public class UserShoppingList
{
    public User User { get; set; } = null!;
    [Column("USER_ID")]
    public int UserId { get; set; }

    public ShoppingList List { get; set; } = null!;
    [Column("SHOPPINGLIST_ID")]
    public int ListId { get; set; }
}