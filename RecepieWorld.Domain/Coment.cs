using System;

public class Coment
{
	public int Id { get; set; }
	public Recipe Recipe { get; set; }
	public int RecipeId { get; set; }
	public User User { get; set; }
	public int UserId { get; set; }
	public string Description { get; set; }
	
}
