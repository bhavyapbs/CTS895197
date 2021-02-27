using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.Cognizant.Moviecruiser.Dao;
using Com.Cognizant.Moviecruiser.Utility;
using Com.Cognizant.Moviecruiser.Model;

namespace Moviecruiser
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                   // MovieDaoCollection movieDaoCollection = new MovieDaoCollection();
                    MovieDaoCollection.ListOfMovies();
                    int id = Convert.ToByte(Request.QueryString["id"].ToString());
                    Movie obj = (from x in MovieDaoCollection.movielist
                                 where x.Id == id
                                 select x).FirstOrDefault();
                    if (obj != null)
                    {
                        TxtTitle.Text = obj.Title;
                        TxtGross.Text = obj.BoxOffice;
                        TxtDate.Text = obj.DateOfLaunch.ToString();
                        DropDownList1.Text = obj.Genre;
                        if (obj.Active == "Yes")
                        {
                            Radioyes.Checked = true;
                        }
                        else
                            Radiono.Checked = true;

                        if (obj.HasTeaser == "Yes")
                            CheckBox1.Checked = true;
                        else
                            CheckBox1.Checked = false;



                        //MovieDaoCollection.movielist.Where(w => w.Id == id).ToList().ForEach(i => TxtTitle.Text = obj.Title);
                    }
                    //foreach (var x in MovieDaoCollection.movielist)
                    //{
                    //    Response.Write(x.Id + " " + x.Title);
                    //    //Response.Write(x.Id + " " + x.BoxOffice);
                    //}
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MovieDaoCollection.ListOfMovies();
            //MovieDaoCollection movieDao = new MovieDaoCollection();
            int id = Convert.ToInt32(Request.QueryString["id"].ToString());
            //Movie obj = (from x in movieDao.movieList
            //             where x.Id == id
            //             select x).FirstOrDefault();
            string active;
            string hasTeaser;
            if (Radioyes.Checked)
            {
                active = "Yes";
            }
            else
            {
                active = "No";
            }
            if (CheckBox1.Checked)
            {
                hasTeaser = "Yes";
            }
            else
            {
                hasTeaser = "No";
            }

            MovieDaoCollection.movielist.Where(w => w.Id == id).ToList().ForEach(i =>
            {
                i.Title = TxtTitle.Text;
                i.BoxOffice = TxtGross.Text;
                
                i.Active = active;
                i.DateOfLaunch = DateUtility.ConvertToDate(TxtDate.Text);
                i.Genre = DropDownList1.SelectedValue;
                
                i.HasTeaser = hasTeaser;
            });
            Response.Redirect("EditMovieStatus.aspx");
        }
    }
}
//            MovieDaoCollection.ListOfMovies();
//            int id = Convert.ToByte(Request.QueryString["id"].ToString());
//            MovieDaoCollection.movielist.Where(w=>w.Id==id).ToList().ForEach(i=>
//            {
//                i.Title = TxtTitle.Text;
//                i.BoxOffice = TxtGross.Text;
//                i.Active = Radioyes.Text;
//                i.DateOfLaunch = DateUtility.ConvertToDate(TxtDate.Text);
//                i.Genre = DropDownList1.SelectedValue;
//                i.HasTeaser = CheckBox1.Text;
//            });
//            Response.Redirect("EditMovieStatus.aspx");
//        }
//    }
//}