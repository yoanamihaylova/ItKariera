using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLibrary
{
    public class Book : IComparable<Book>
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private IReadOnlyList<string> authors;

        public IReadOnlyList<string> Authors
        {
            get { return authors; }
            set { authors = value; }
        }
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }

        public int CompareTo(Book other)
        {
            int result = this.Year.CompareTo(other.Year);
            if (result == 0)
            {
                result = this.Title.CompareTo(other.Title);
            }
            return result;
        }

    }
}
