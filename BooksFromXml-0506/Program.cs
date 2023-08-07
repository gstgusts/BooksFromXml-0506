using BooksFromXml_0506.Models;

namespace BooksFromXml_0506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new XmlDataReader<List<Book>>("catalog");

            var result = reader.Read(@"Data\books.xml");

            //var writer = new XmlDataWriter<List<Book>>("catalog");

            //var list = new List<Book>();

            //list.Add(new Book
            //{
            // Author = "test",
            // Genre = "test1",
            //  Description = "test2",
            //     Id = "id",
            //      Price = 1,
            //         PublishDate = DateTime.Now,
            //         Title = "Test",
            //});

            //list.Add(new Book
            //{
            //    Author = "test12",
            //    Genre = "test1",
            //    Description = "test212",
            //    Id = "id",
            //    Price = 1,
            //    PublishDate = DateTime.Now,
            //    Title = "Test",
            //});

            //writer.Write(@"Data\books2.xml", list);
        }
    }
}