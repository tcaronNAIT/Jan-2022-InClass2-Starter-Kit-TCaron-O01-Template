using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Author
    {
        public string AuthorName { get; private set; }
        public string ContactURL { get; private set; }

        public Author(string authorname, string contacturl)
        {
            if(string.IsNullOrWhiteSpace(authorname))
            {
                throw new ArgumentNullException($"{nameof(authorname)} is requried");
            }

            if (string.IsNullOrWhiteSpace(contacturl))
            {
                throw new ArgumentNullException($"{nameof(contacturl)} is requried");
            }

            AuthorName = authorname;
            ContactURL = contacturl;
        }

        public override string ToString()
        {
            return $"{AuthorName},{ContactURL}";
        }

        //TODO 1: Create Parse() and TryParse() methods

    }
}
