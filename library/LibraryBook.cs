using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace library
{
    public class LibraryBook
    {
        private uint ID;
        private string Title;
        private string Author;
        private List<string> Content;

        public uint GetID()
        {
            return ID;
        }

        public string GetTitle()
        {
            return Title;
        }

        private void SetID(uint NewID)
        {
            ID = NewID;
        }

        private void SetTitle(string FileName)
        {
            StreamReader streamreader = new StreamReader(FileName, System.Text.Encoding.Default);
            StringBuilder tmpline = new StringBuilder(streamreader.ReadLine());
            tmpline.Remove(0, 7);
            Title = tmpline.ToString();
            streamreader.Close();
        }

        private void SetAuthor(string FileName)
        {
            StreamReader streamreader = new StreamReader(FileName, System.Text.Encoding.Default);
            streamreader.ReadLine();
            StringBuilder tmpline = new StringBuilder(streamreader.ReadLine());
            tmpline.Remove(0,8);
            Author = tmpline.ToString();
            streamreader.Close();
        }

        private void SetContent(string FileName)
        {
            string tmpline;
            StreamReader streamreader = new StreamReader(FileName, System.Text.Encoding.Default);
            Content = new List<string>();
            streamreader.ReadLine();
            streamreader.ReadLine();
            while ((tmpline = streamreader.ReadLine()) != null)
            {
                Content.Add(tmpline);
            }
            streamreader.Close();
        }

        public LibraryBook(string FileName, uint NewID)
        {
            SetID(NewID);
            SetTitle(FileName);
            SetAuthor(FileName);
            SetContent(FileName);
        }
    }
}