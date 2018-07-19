using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows2
{
    class Book
    {
        string _ISBN;
        string _year;
        string _AuthorName;
        string _Edition;
        string _Title;

        public string ISBN
        {
            get
            {
                return _ISBN;
            }
            set
            {
                _ISBN = value;
            }
        }

        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }
        public string AuthorName
        {
            get
            {
                return _AuthorName;
            }
            set
            {
                _AuthorName = value;
            }
        }
        public string Edition
        {
            get
            {
                return _Edition;
            }
            set
            {
                _Edition = value;
            }
        }
        public string year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
    }
}
