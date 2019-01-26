using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SB_Proj.ViewModels
{
    public class ViewBook
    {
        public ViewBook(int bookID, string title, DateTime releaseDate, decimal price, int amount)
        {
            BookID = bookID;
            Title = title;
            ReleaseDate = releaseDate.ToShortDateString();
            Price = string.Format("{0:0.00}", price).Replace(',','.');
            Amount = amount;
        }

        public int BookID { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public string Price { get; set; }
        public int Amount { get; set; }
    }
}
