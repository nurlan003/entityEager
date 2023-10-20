
using ConsoleApp1.Context;
using ConsoleApp1.Modelss;
using Microsoft.IdentityModel.Protocols;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

//EXERCISE1

LibraryDbContext libraryDbContext = new LibraryDbContext();
//foreach (Press press in libraryDbContext.Presses.Include(press => press.Books).ToList())
//{
//    Console.WriteLine($"press name:{press.Name}");

//    var minpagebook = press.Books.OrderBy(book => book.Pages).FirstOrDefault();
//    if (minpagebook != null)
//    {
//        Console.WriteLine($"book with minimum pages: {minpagebook.Name}");
//        Console.WriteLine($"minimum pages: {minpagebook.Pages}");
//    }
//    else
//    {
//        Console.WriteLine("no books found for this press.");
//    }
//    Console.WriteLine("\n\n");
//}


//EXERCISE2

//foreach (Press press in libraryDbContext.Presses.Include(press => press.Books).ToList())
//{

//    var booksPageCounts = press.Books.Select(book => book.Pages).ToList();

//    if (booksPageCounts.Any() && booksPageCounts.Average() > 100)
//    {
//        Console.WriteLine(press.Name);
//    }

//    Console.WriteLine("\n\n");
//}


//exercise3

int BookSumCount = 0;
foreach (var press in libraryDbContext.Presses)
{
    if (press.Name == "BHV" || press.Name == "BINOM") {
        foreach (var book in press.Books)
        {
           
        }
    }
}
Console.WriteLine(  BookSumCount);

