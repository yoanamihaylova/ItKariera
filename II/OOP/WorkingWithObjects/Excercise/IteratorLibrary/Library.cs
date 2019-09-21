using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLibrary
{
   
    public class Library : IEnumerable<Book>
    {

         private class LibraryIterator : IEnumerator<Book>
         {
                private List<Book> books;
                private int currentIndex;
                public LibraryIterator(IEnumerable<Book> books)
                {
                    this.Reset();
                    this.books = new List<Book> (books);
                }                      
                public void Dispose()
                {

                }
                public bool MoveNext()
                {
                    return ++this.currentIndex < this.books.Count;
                }
                public Book Current => this.books[this.currentIndex];
                public void Reset() => this.currentIndex = -1;
                object IEnumerator.Current => this.Current;  
         }               
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            /*foreach (var item in books)
            {
                yield return item;
            }*/
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
    
}
