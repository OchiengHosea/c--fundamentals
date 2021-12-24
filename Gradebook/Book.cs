using System;
using System.Collections.Generic;

namespace Gradebook
{
    public class Book
    {
        public Book(string name, int publicationYear, List<string> authors)
        {
            Authors = authors;
            Name = name;
            PublicationYear = publicationYear;
        }

        private string Name;
        private int PublicationYear;
        private List<string> Authors;

        public string AddAuthor(string name)
        {
            Authors.Add(name);
            return name;
        }

        public void PrintAuthors()
        {
            foreach (string author in Authors) Console.WriteLine(author);
        }

        public void PrintBook()
        {
            Console.WriteLine(Name + " " + PublicationYear);
        }
    }
}
