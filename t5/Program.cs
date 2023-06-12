// See https://aka.ms/new-console-template for more information
using t5;


Book book = new Book();
book.Name = "C# opas";
book.Author = "Teppo Testi";
book.PublicationYear = 2021;

Book book2 = new Book("Java","Matti Virta",2019);

Console.WriteLine("Ensimmäinen olio");
Console.WriteLine(book.Name);
Console.WriteLine(book.Author);
Console.WriteLine(book.PublicationYear.ToString());

Console.WriteLine("Toinen olio");
Console.WriteLine(book2.Name);
Console.WriteLine(book2.Author);
Console.WriteLine(book2.PublicationYear.ToString());