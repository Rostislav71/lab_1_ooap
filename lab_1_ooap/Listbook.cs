using System;
using System.Collections.Generic;
using System.Text;

namespace lab_1_ooap
{
    public class Listbook
    {
        public int Number
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }

        List<Listbook> homeLibraryList = new List<Listbook>();

        public void Add(Listbook homeLibrary)
        {
            homeLibraryList.Add(homeLibrary);
        }

        public void Remove(Listbook homeLibrary)
        {
            homeLibraryList.Remove(homeLibrary);

        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Listbook objHomeLibrary = obj as Listbook;
            if (objHomeLibrary == null)
                return false;
            return true;
        }

        public override string ToString()
        {
            return Number + " " + Author + " " + Year + " " + Category;
        }

        public void ShowScreen()
        {
            foreach (var VARIABLE in homeLibraryList)
            {
                Console.WriteLine(VARIABLE.ToString());
            }
            Console.WriteLine("\n");
        }

        public void Search(string str, int number)
        {

            foreach (var VARIABLE in homeLibraryList)
            {
                if (number == 1 && VARIABLE.Author == str)
                {
                    Console.WriteLine(VARIABLE.ToString());
                }
                else if (number == 2 && VARIABLE.Year == Convert.ToInt32(str))
                {
                    Console.WriteLine(VARIABLE.ToString());
                }
                else if (number == 3 && VARIABLE.Category == str)
                {
                    Console.WriteLine(VARIABLE.ToString());
                }
                else if (number == 4 && VARIABLE.Number == Convert.ToInt32(str))
                {
                    Console.WriteLine(VARIABLE.ToString());
                }
            }
        }
    }
}
