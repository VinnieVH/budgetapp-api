using BudgetApp.Api.DataAccess.Models;

namespace BudgetApp.Api.Queries;

public class BookQueries
{
    public Book GetBook() =>
        new Book
        {
            Title = "C# in depth.",
            ISBN = "978-3-0564-3584-2",
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };
}