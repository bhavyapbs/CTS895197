using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Moviecruiser.Model;
using Com.Cognizant.Moviecruiser.Utility;

namespace Com.Cognizant.Moviecruiser.Dao
{
    public class FavoritesDaoCollection : IFavoritesDao
    {

        public static List<Movie> favoritesmovielist = null;

        static public void FavoritesListInitialization()
        {
            if (favoritesmovielist == null)
            {
                favoritesmovielist = new List<Movie>()
                {
                     new Movie() { Id=1, Title="Avatar",BoxOffice="$2,787,965,087",
             Active="Yes",DateOfLaunch=DateUtility.ConvertToDate("15/03/2017"),
                 Genre="Science Fiction", HasTeaser="Yes"},
                       new Movie() { Id=2, Title="The Avengers",BoxOffice="$1,518,812,988",
             Active="Yes", DateOfLaunch = DateUtility.ConvertToDate("23/12/2017"),
                 Genre="Superhero", HasTeaser="No"},
               new Movie() { Id=3, Title="Titanic",BoxOffice="$2,187,463,944",
             Active="Yes", DateOfLaunch = DateUtility.ConvertToDate("21/08/2017"),
                 Genre="Romance", HasTeaser="No"},

                };
            }
        }
        public void AddMovieToFavorites(int userId, int MovieId)
        {
            
        }
        public void GetAllMovieFromFavorites(int userId)
        {

        }
        public void RemoveMovieFromFavorites(int userId, int MovieId)
        {

        }

    }

}