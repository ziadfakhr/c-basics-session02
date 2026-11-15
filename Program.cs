namespace c_basics_session02
{
    //  "creating class" 
    class Book
    {
        public int Page { get; set; }
        public string Title { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // question 1 
            Book book = new Book(); 
            book.Page = 1;
            book.Title = "book";
            object obj = book ;

            Console.WriteLine(obj);

            //question 2 
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());

            //question 3 

            int Pages = 464; // make it int not string 

            Console.WriteLine(Pages);

            // question 4 

            try
            {
                int zero = 0; // عشان مش يعمل كومبايل ايرور 
                int num = 10;
                Console.WriteLine(num / zero);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cannot divide by 0");
            }
            finally
            {
                Console.WriteLine("done");
            }


        }
    }
}
