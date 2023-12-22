// See https://aka.ms/new-console-template for more information
using nasledovanie2;

Console.WriteLine("Hello, World!");
Random rnd = new Random();
Book[] books = new Book[] {
    new Book("Война и Мир","Толстой",rnd.NextDouble()*100),
    new BookGenre("Буратино","Не помню",rnd.NextDouble()*100,"Фантастика"),
    new BookGenrePubl("Приключения Лобачевского","Народная",rnd.NextDouble()*100,"Боевик","Мос.издательство"),
};
foreach (var book in books) {
    book.Print();
}