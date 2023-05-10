using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.BL
{
    public class Book
    {
        public Book(string author, int pages, List<string> Chapters, int bookmark, float price)
        {
            this.author = author;
            this.pages = pages;
            this.Chapters = Chapters;
            this.bookmark = bookmark;
            this.price = price;
        }
        public string author;
        public int pages;
        public List<string> Chapters;
        public int bookmark;
        public float price;

        public string GetChapter(int number)
        {
            string nameChapter = "Not Exist";
            if(number < Chapters.Count)
            {
                nameChapter = Chapters[number];
            }
            return nameChapter;
        }
        public int GetBookmark()
        {
            return bookmark;
        }
        public void SetBookmark(int bookmark)
        {
            this.bookmark = bookmark;
        }
        public float GetPrice()
        {
            return price;
        }
        public void SetPrice(float price)
        {
            this.price = price;
        }
    }
}
