using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LibraryBook> Books = new List<LibraryBook>();
            string DirectoryPattern = @"H:\store\works\Учёба\C#\academy\library\library\resource\";
            string[] BooksNames = Directory.GetFiles(DirectoryPattern);
            uint id = 0;
            while (id < (uint)BooksNames.Count())
            {
                Books.Add(new LibraryBook(BooksNames[id], id+1));
                id++;
            }
            LibraryInterface.StartMenu(Books);
        }
    }
}
