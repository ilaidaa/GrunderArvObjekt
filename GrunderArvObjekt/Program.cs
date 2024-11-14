using static GrunderArvObjekt.FilmListan;

namespace GrunderArvObjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa tre insatser av klassen Movie
            //1.
            Movie movie1 = new Movie("Titanic", "James Cameron", new DateOnly(1998, 01, 16), 195, false, new string[] { "Leonardo Dicaprio", "Kate Winslet", "Billy Zane" });

            //2.
            Movie movie2 = new Movie("Finding Nemo", "Andrew Stanton", new DateOnly(2003, 05, 30), 185, true, new string[] { "Elen Degerens", "Albert Brooks" });

            //3. 
            Movie movie3 = new Movie("Inception", "Christopher Nolan", new DateOnly(2010, 7, 16), 165, false, new string[] { "Leonardo Dicaprio", "Joseph Morgon" });




            //Skriv ut filmerna
            Console.WriteLine(movie1.BuildStory());
            Console.WriteLine(movie2.BuildStory());
            Console.WriteLine(movie3.BuildStory());
        }
    }
}
