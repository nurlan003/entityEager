
using ConsoleApp1.Context;
using ConsoleApp1.Modelss;
using Microsoft.IdentityModel.Protocols;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Diagnostics;

LibraryDbContext libraryDbContext = new LibraryDbContext();
//EXERCISE1

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


//EXERCISE3

//string pres1 = "BHV";
//string pres2 = "Binom";
//int totalBHVBinom = 0;
//foreach (Press press in libraryDbContext.Presses.Include(press => press.Books).ToList())
//{
//    bool var1 = press.Name.Contains(pres1);
//    bool var2 = press.Name.Contains(pres2);

//    if (var1)
//    {
//        int totalPageCount = press.Books.Sum(bk => bk.Pages);
//        totalBHVBinom += totalPageCount;

//    }

//    if (var2)
//    {
//        int totalPageCount = press.Books.Sum(bk => bk.Pages);

//        totalBHVBinom += totalPageCount;

//    }


//}
//Console.WriteLine(  totalBHVBinom);


//EXERCISE4
//DateTime datein = new DateTime(2001, 1, 1);

//foreach (Student std in libraryDbContext.Students.Include(st => st.SCards).ToList())
//{

//    foreach (var sCard in std.SCards.ToList())
//    {
//        int dateCompare = DateTime.Compare(datein, sCard.DateOut);

//        if (dateCompare < 0)
//        {
//            Console.WriteLine(std.FirstName);
//        }
//    }
//}


//EXERCISE5
//Console.WriteLine($"Students which worked with 'Windows 2000 registry' ");
//foreach (Student std in libraryDbContext.Students.Include(st=>st.SCards).ToList())
//{
//	foreach (var sCard in std.SCards.ToList())
//	{
//		foreach (var bk in libraryDbContext.Books.ToList())
//		{
//			bool boolBook = bk.Name.Contains("Windows 2000 registry");
//			if (boolBook)
//			{
//				if (sCard.IdBook == bk.Id)
//				{
//                    Console.WriteLine(	std.FirstName);
//                }
//			}
//		}
//	}
//}


//EXERCISE6

//Console.WriteLine("Authors whose average number of pages is more than 600"); 
//foreach (var ath in libraryDbContext.Authors.Include(att => att.Books).ToList())
//{
//    int totalBookCount = ath.Books.Count;
//    int totalPageCount = ath.Books.Sum(bk => bk.Pages);
//    int AVGPages = totalPageCount / totalBookCount;
//    if (AVGPages > 600)
//    {
//        Console.WriteLine(ath.FirstName + " " + ath.LastName);
//        Console.WriteLine("\n");
//    }
//}


//EXERCISE7 
//foreach (var pres in libraryDbContext.Presses.Include(pre=>pre.Books).ToList())
//{
//    int totalBookPagesCount = pres.Books.Sum(BK => BK.Pages);
    
//    if (totalBookPagesCount > 700)
//    {
//        Console.WriteLine(pres.Name);

//    }
  
//}
















