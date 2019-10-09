using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment_n01353378
{
    public partial class Coordinate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {

                Page.Validate();

                if (Page.IsValid)
                {

                    // ASSIGN VARIABLES FOR VALUES
                    int Coordinate_X = Convert.ToInt32(coordinate_x.Text);
                    int Coordinate_Y = Convert.ToInt32(coordinate_y.Text);

                    coordinates_summary.InnerHtml = "";

                    // IF X AND Y ARE POSITIVE NUMBERS, THEN THEY ARE IN QUADRANT I.
                    // IF X IS NEGATIVE AND Y IS POSITIVE, THEN THEY ARE IN QUADRANT II.
                    // IF X IS POSITIVE AND Y IS NEGATIVE, THEN THEY ARE IN QUADRANT III.
                    // IF X AND Y ARE NEGATIVE, THEN THEY ARE IN QUADRANT IV.
                    coordinates_summary.InnerHtml += "(" + Coordinate_X + "," + Coordinate_Y + ")" + "</br>";

                    if (Coordinate_X > 0 && Coordinate_Y > 0)
                    {
                        coordinates_summary.InnerHtml += "Quadrant I";
                    }

                    if (Coordinate_X < 0 && Coordinate_Y > 0)
                    {
                        coordinates_summary.InnerHtml += "Quadrant II";
                    }

                    if (Coordinate_X < 0 && Coordinate_Y < 0)
                    {
                        coordinates_summary.InnerHtml += "Quadrant III";
                    }

                    if (Coordinate_X > 0 && Coordinate_Y < 0)
                    {
                        coordinates_summary.InnerHtml += "Quadrant IV";
                    }
                }
            }
        }
    }
}