using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace library
{
    static public class LibraryInterface
    {

        static public void StartMenu(List<LibraryBook> BookList)
        {
            Console.Clear();
            Console.Write("Select activity:\n1 - show all;\n2 - exit;\nyour choise: ");
            char flag = Convert.ToChar(Console.Read());
            switch (flag)
            {
                case '1':
                    {
                        ShowAll(BookList);
                        break;
                    }
                case '2':
                    {
                        Exit();
                        break;
                    }
                default:
                    {
                        ErrorProcess();
                        break;
                    }
            }
        }

        static public void ShowAll(List<LibraryBook> BookList)
        {
            Console.Clear();
            for (uint i = 0; i < BookList.Count; i++)
            {
                Console.WriteLine("Book №{0} - {1}", BookList[(int)i].GetID(), BookList[(int)i].GetTitle());
            }
            Console.ReadKey();
        }

        static public void Exit()
        {
        }

        static public void ErrorProcess()
        {
        }

    }
}
