using MOVIESWITHFIRSTDB.Models;

namespace MOVIESWITHFIRSTDB
{
    internal class Program
    {
        static void Main()
        {
            MoviesContext mc = new MoviesContext();
            List<MovieInventory> movies = mc.MovieInventories.ToList();

            Movies mov = new Movies();

            List <string> hellolist = mov.SearchByGenere();
            mov.ReturnedTitle(hellolist);


            List<string> hellolist2 = mov.SearchbyTitle();
            mov.ReturnedTitle(hellolist2);

        }






    }
}