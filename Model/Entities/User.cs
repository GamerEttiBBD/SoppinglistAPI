namespace Model.Entities; 

[Table("USERS")]
public class User {

    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("USER_ID")]
    public int Id { get; set; }

    [Column("USERNAME")]
    [Required, StringLength(45)]
    public string Name { get; set; } = null!;
}