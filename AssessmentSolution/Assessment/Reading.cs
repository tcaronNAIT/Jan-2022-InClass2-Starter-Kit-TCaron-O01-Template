using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Reading
    {

        private string _Title;
        private int _Year;
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"Title is requried");
                }
                _Title = value;
            }
        }

        public ArticleType Type { get; set; }

        public int Year
        {
            get { return _Year; }
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"Year must be a positive non-zero value. You entered {value}");
                }
                if (value > DateTime.Today.Year)
                {
                    throw new ArgumentOutOfRangeException($"Year must not be in the future. You entered {value}");
                }

                _Year = value;
            }
        }

        public Reading(string title, ArticleType type, int year)
        {
            Title = title;
            Type = type;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Title},{Type},{Year}";
        }

    }
}
