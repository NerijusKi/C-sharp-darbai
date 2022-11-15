using System;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address
            {
                City = "Kaunas",
                Country = "Lietuva",
                Street = "laisves al.",
                PostCode = 56654
            };




            Book altoriuSesely = new Book("156-156-4444");
            //altoriuSesely.ISBN = "156-156-4444";
            altoriuSesely.Title = "Altoriu sesely";
            altoriuSesely.PageCount = 535;
            altoriuSesely.PublishedDate = new DateTime(1995, 02, 14);
            altoriuSesely.Author = new Author() { FirstName = "Tomas", LastName = "Pavardenis" };
            altoriuSesely.Genre = Genre.Thriller;


            Book lapkritis = new Book("156-147-4422");
            //altoriuSesely.ISBN = "156-156-4444";
            lapkritis.Title = "Lapkritis";
            lapkritis.PageCount = 189;
            lapkritis.PublishedDate = new DateTime(1997, 03, 15);
            lapkritis.Author = new Author() { FirstName = "Tomas", LastName = "Manas" };
            lapkritis.Genre = Genre.Romance;

            Library viesojiBiblioteka = new Library(Address.GetViesojiBiblioteka());
            viesojiBiblioteka.Books.Add(altoriuSesely);
            viesojiBiblioteka.Books.Add(lapkritis);


            foreach (var book in viesojiBiblioteka.Books)
            {
                Console.WriteLine(book.Title);
            }

            //Book brisiausGalas = new Book();
            //Book GirlOnTrain = new Book();
            //Book KarasIrTaika = new Book();

        }
    }
}
