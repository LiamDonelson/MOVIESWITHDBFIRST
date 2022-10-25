using MOVIESWITHFIRSTDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIESWITHFIRSTDB
{
    public class Movies
    {

        public List<string> SearchByGenere()
        {
            MoviesContext mc = new MoviesContext();
            List<MovieInventory> movies = mc.MovieInventories.ToList();
            List<string> search = new List<string>();


            Console.WriteLine("Please type in a Genere that you would like to search for, we have:");


            // prints all of 
            List<string> movieGeneres = new List<string>();
            foreach (MovieInventory movie in movies)
            {
                if (movieGeneres.Contains(movie.Genere) == false)
                {
                    movieGeneres.Add(movie.Genere);
                }
            }

            // prints all movie generes
            foreach (string mo in movieGeneres)
            {
                Console.WriteLine(mo);
            }



            Console.WriteLine("-----------------------------------------------------------------");
            string userinput = Console.ReadLine();

            Console.WriteLine("Alrighty! Here are the movies we have in that genere!");
            List<string> SelectedMovies = new List<string>();
            foreach (MovieInventory movie in movies)
            {
                if (movie.Genere.Contains(userinput))
                {
                    search.Add(movie.MovieName);
                }
            }
            return search;
        }


        public List<string> SearchbyTitle()
        {
            List<MovieInventory> search = new List<MovieInventory>();
            MoviesContext mc = new MoviesContext();

            Console.WriteLine("Please type in a Title that you would like to search for");
            string userinput = Console.ReadLine();

            Console.WriteLine();

            List<string> movieNames = new List<string>();

            search = mc.MovieInventories.Where(m => m.MovieName.Contains(userinput)).ToList();

            return search.Select(m => m.MovieName).ToList();
        }






        public void ReturnedTitle(List<string> hellofools)
        {
            MoviesContext mc = new MoviesContext();
            List<MovieInventory> movies = mc.MovieInventories.ToList();

            Console.WriteLine("Select a Movie");
            int i = 1;
            foreach (string movie in hellofools)
            {
                Console.WriteLine($"|{i}| {movie}");
                i++;
            }

            int userinput = int.Parse(Console.ReadLine());
            string chosenmovie = hellofools[userinput - 1];

            foreach (MovieInventory moves in movies)
            {

                if (chosenmovie.Equals(moves.MovieName))
                {
                    Console.WriteLine($"Movie Title:{moves.MovieName} \nMovie Genere:{moves.Genere} \nMovie Run Time: {moves.RunTime}");
                    break;
                }

            }

        }




    }
}
