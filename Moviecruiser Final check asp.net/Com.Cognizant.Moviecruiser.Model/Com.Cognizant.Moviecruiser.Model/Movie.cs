using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Moviecruiser.Model
{
    public class Movie
    {
        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        string boxoffice;
        public string BoxOffice
        {
            get { return boxoffice; }
            set { boxoffice = value; }
        }
        string active;
        public string Active
        {
            get { return active; }
            set { active = value; }
        }
        DateTime dateoflaunch;
        public DateTime DateOfLaunch
        {
            get { return dateoflaunch; }
            set { dateoflaunch = value; }
        }
        string genre;
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        string hasteaser;
        public string HasTeaser
        {
            get { return hasteaser; }
            set { hasteaser = value; }
        }


        //DEFAULT CONSTRUCTOR
        public Movie() { }

        //MOVIE CONSTRUCTOR
        public Movie(int Id, string Title, string BoxOffice, string Active, DateTime DateOfLaunch, string Genre, string HasTeaser)
        {
            this.Id = Id;
            this.Title = Title;
            this.BoxOffice = BoxOffice;
            this.Active = Active;
            this.DateOfLaunch = DateOfLaunch;
            this.Genre = Genre;
            this.HasTeaser = HasTeaser;
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
