using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Controller
{
    internal class Controller
    {
        View.Views view = new View.Views();
        Model.Book cBook = new Model.Book();


        #region Main Controller
        public void MainController()
        {
            Combiner();
        }
        #endregion

        #region Combiner
        void Combiner()
        {
            InsertData();
        }
        #endregion

        #region Insert Data
        void InsertData()
        {
            Model.Book book1 = new Model.Book
            {
                TotalPages = 300,
                Price = 25,
                Title = "Simple Book",
                Author = "John Doe",
                Language = "English",
                ReleaseDate = "01-01-2023"
            
            };

            Model.Book book2 = new Model.Book
            {
                TotalPages = 450,
                Price = 30,
                Title = "Another Book",
                Author = "Jane Smith",
                Language = "France",
                ReleaseDate = "25-08-2023"
            };

            Model.Book book3 = new Model.Book
            {
                TotalPages = 50,
                Price = 10000,
                Title = "Shazils Book",
                Author = "Shazil Shahid Qayyum Abdul Aziz Muhammad Ali",
                Language = "Urdu",
                ReleaseDate = "23-01-2004"
            };

            Model.Book book4 = new Model.Book
            {
                TotalPages = 600,
                Price = 9999,
                Title = "Jonas' Book",
                Author = "Jonas Kristian Anders Torben",
                Language = "Deutch",
                ReleaseDate = "01-09-1939"
            };
        }
        #endregion

    }
}
