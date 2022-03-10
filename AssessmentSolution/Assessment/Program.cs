// See https://aka.ms/new-console-template for more information
using Assessment;
using System.Text.Json;

Run();

static void Run()
{
    try
    {
        #region load Publication  DO NOT ALTER THIS REGION


        //Create an instance of the Reading class
        Reading theReading = new Reading("Fundamental Programming", ArticleType.Book, 2001);
       
        //Create an instance of the Publication class
        Publication thePublication = new Publication(theReading);
       
        //Load good authors to the publication instance
        thePublication.Authors.Add(new Author("Robbin Law", "robbinl@booklist.com"));
        thePublication.Authors.Add(new Author("Don Welch", "dwelch@nait.ca"));
        thePublication.Authors.Add(new Author("Writ Tin", "writtin@hotmail.com"));

        DisplayPublication(thePublication);       
        #endregion

        #region Test TryParse/Parse

        Author author = null;

        //testing good TryParse/Parse
        Console.WriteLine("\n\nTesting success for TryParse/Parse\n");
        //string GoodAuthorParse = "Good Author Parse,goodauthorparse@publish.com";
        //bool success = Author.TryParse(GoodAuthorParse, out author);
        //Console.WriteLine($"Good author parsing of {author.ToString()}");

        //testing exceptions
        Console.WriteLine("\n\nTesting Exceptions for TryParse/Parse\n");
        //string BadAuthorName = ",badauthorname@publish.com";
        //success = Author.TryParse(BadAuthorName, out author);
        //string BadAuthorURL = "No Contact,";
        //success = Author.TryParse(BadAuthorURL, out author);
        #endregion

        #region Test Publication.AddAuthor
        Author addAuthor = null;
        //testing good TryParse/Parse
        Console.WriteLine("\n\nTesting success for AddAuthor()\n");

        //addAuthor =new Author("Don Welch", "dwelch@sait.ca");
        //thePublication.AddAuthor(addAuthor);
        //addAuthor =new Author("Tom Welch", "dwelch@nait.ca");
        //thePublication.AddAuthor(addAuthor);
        //Console.WriteLine("Successful AddAuthor() adds");

        //testing exceptions
        Console.WriteLine("\n\nTesting Exceptions for AddAuthor(Author)\n");
        //author=null;
        //thePublication.AddAuthor(author);
        //addAuthor =new Author("Don Welch", "dwelch@sait.ca");
        //thePublication.AddAuthor(addAuthor);
        //addAuthor =new Author("Tom Welch", "dwelch@nait.ca");
        //thePublication.AddAuthor(addAuthor);
        #endregion

        #region Test Output to JSON File

        //INSTRUCTION: Replace xxxx with your name.
        string pathname = "../../../DonWelch.json";
        Console.WriteLine("\n\nTesting success for writting JSON file\n");

        //TODO 3: Output Publication to JSON file

       
        Console.WriteLine("Json file was created.\n");
        #endregion

        #region Read CSV file of Author records and add to Publication
        Console.WriteLine("\n\nTesting success for reading CSV file and adding to Publicaition\n");
        Author authorCSV = null;

        //TODO 4: Read and load CSV Author file

       
        DisplayPublication(thePublication);

        #endregion

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception: {ex.Message}");
    }
}

static void DisplayPublication(Publication thePublication)
{
    //Write the contents of your publication 
    Console.WriteLine("\nThe current Publication data for our instances are:\n");
    Console.WriteLine(thePublication.Article.ToString());
    Console.WriteLine($"Total number of authors for this reading is {thePublication.TotalAuthors}");
    foreach (var item in thePublication.Authors)
        Console.WriteLine(item.ToString());
}
