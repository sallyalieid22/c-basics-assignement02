namespace assignment_2
{
    internal class Program
    { static string[] books =

   {
        "clean code",
        "the pragmatic programmer",
        "refactoring"
    };
        
        static void Main(string[] args)
        {
             //question 1
            int pages = 464;
            if (pages > 300)
            {
                Console.WriteLine("long book");
            }
            else
            {
                Console.WriteLine("short book");

            }
            //question 2
            bool isavailable = true;
            if (pages > 300 && isavailable == true)
            {
                Console.WriteLine("you can borrow this book");
            }
            //question 3
            string title = "refactoring";
            switch (title)
            {
                case "clean code":
                    Console.WriteLine("great choice");
                    break;
                case "refactoring":
                    Console.WriteLine("nice pick");
                    break;
                default:
                    Console.WriteLine("never heard of it");
                    break;

            }
            //question 4
            string sizelable = pages > 300 ? "long book" : "short book";
            Console.WriteLine(sizelable);

            //question 5
            for (int i = 0; i < books.Length; i++)
            {


                Console.WriteLine((i + 1) + "." + books[i]);

            }
            //question 6
            int j = 0;

            while (j < books.Length)
            {

                Console.WriteLine(books[j]);
                j++;


            }
            //question 7
            int count = 0;
            do
            {
                Console.WriteLine("checking book");
                count++;
            }
            while (count < 30);
            //question 8
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            //question 9

            foreach (string book in books)
            {
                Console.WriteLine(book);
                if (book == "refactoring")


                    break;
            }

            //question 10

            foreach (string book in books)


            {
                if (book == "the pragmatic programmer")

                    continue;

                Console.WriteLine(book);
            }

            //question 11
            static void PrintFirstBook()
            {
                if (books.Length == 0)
                {

                    return;


                    Console.WriteLine(books[0]);


                }
            }

























        }

    }



}
   

           
