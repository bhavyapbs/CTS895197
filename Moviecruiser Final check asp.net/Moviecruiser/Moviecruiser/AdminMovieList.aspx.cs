using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.Cognizant.Moviecruiser.Dao;

namespace Moviecruiser
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                MovieDaoCollection movieDaoCollection = new MovieDaoCollection();
            MovieDaoCollection.ListOfMovies();
                GridView1.DataSource = MovieDaoCollection.movielist;
                GridView1.DataBind();


            }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
