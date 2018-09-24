﻿namespace _09BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputFile = File.ReadAllLines("input.txt");

            var books = new List<Book>();

            for (int i = 1; i < inputFile.Length; i++)
            {
                books.Add(ReadBook(inputFile[i]));
            }

            Library library = new Library { Name = "Library", Books = books };

            var authors = new Dictionary<string, double>();

            foreach (Book book in library.Books)
            {
                if (authors.ContainsKey(book.Author))
                {
                    authors[book.Author] += book.Price;
                }
                else
                {
                    authors[book.Author] = book.Price;
                }
            }

            foreach (var item in authors.OrderByDescending(b => b.Value).ThenBy(b => b.Key))
            {
                File.AppendAllText("output.txt", $"{item.Key} -> {item.Value:f2}");
                File.AppendAllText("output.txt", Environment.NewLine);
            }
        }
        private static Book ReadBook(string input)
        {
            string[] tokens = input.Split();

            string title = tokens[0];
            string author = tokens[1];
            string publisher = tokens[2];
            DateTime releaseDate = DateTime.ParseExact(tokens[3], "d.M.yyyy", CultureInfo.InvariantCulture);
            int isbn = int.Parse(tokens[4]);
            double price = double.Parse(tokens[5]);

            return new Book { Title = title, Author = author, Publisher = publisher, ReleaseDate = releaseDate, ISBN = isbn, Price = price };
        }

        public class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public int ISBN { get; set; }
            public double Price { get; set; }
        }
    }
}