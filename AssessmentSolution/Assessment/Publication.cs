using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Publication
    {
        public Reading Article { get; private set; }
        public List<Author> Authors { get; set; }
        public int TotalAuthors { get { return Authors.Count; } }

        public Publication(Reading article)
        {
            if (article == null)
                throw new ArgumentNullException("Publication needs an article");
            Article = article;
            Authors = new List<Author>();
        }


        public void AddAuthor(Author author)
        {
            //TODO 2: Complete AddAuthor(Author) method

        }
    }
}
