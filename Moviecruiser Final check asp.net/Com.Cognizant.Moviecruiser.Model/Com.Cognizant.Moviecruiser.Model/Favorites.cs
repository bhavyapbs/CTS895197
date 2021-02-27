using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Moviecruiser.Model
{
    public class Favorites
    {
        private List<Movie> menuItemList;

        public List<Movie> MenuItemList
        {
            get { return menuItemList; }
            set { menuItemList = value; }
        }

        private double total;

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
