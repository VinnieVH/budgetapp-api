namespace BudgetApp.Api.DataAccess.Models;

public class Book
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public required string ISBN { get; set; }
    public double? Price { get; set; }
    public required Author Author { get; set; }
}