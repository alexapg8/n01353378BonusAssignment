using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment_n01353378
{
    public partial class RaffleBundle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {

                Page.Validate();

                if (Page.IsValid)
                {
                    
                    tickets_summary.InnerHtml = "";
                    tickets_summary.InnerHtml += "Here is a summary of your tickets: </br>";
                    // GATHER INFORMATION ABOUT HOW MANY TICKETS THE USER WANTS
                    int Ticket_Num = Convert.ToInt32(ticket_num.Text);


                    // DEPENDING ON THE NUMBER OF TICKETS THEY WILL BE SEPARATED IN BUNDLES
                    // 1 TO 50 = NO BUNDLE
                    // 51 TO 150 = BUNDLE OF 2
                    // 151 TO 300 = BUNDLE OF 3
                    // 301 AND HIGHER = BUNDLE OF 4

                    // The number of tickets have to be divided between the bundle, the remainder (modulus) would be printed as a leftover ticket.
                    for (int i = 1; i == Ticket_Num; i++)
                    {
                        // when i comment out the "for" the if statement works, if not, it doesn't run
                        if (Ticket_Num <= 50)
                        {       
                           tickets_summary.InnerHtml += "You have recieved a bundle of 1! That's"  + i +  " ticket(s)! </br>";
                        }
                        else if (Ticket_Num >= 51 && Ticket_Num <= 150) 
                        {
                            // bundle of 2
                            tickets_summary.InnerHtml += "You have recieved a bundle of 2! That's"  + Ticket_Num + " ticket(s)! </br>";
                        }
                        else if (Ticket_Num >= 151 && Ticket_Num <= 300)
                        {
                            // bundle of 3
                            tickets_summary.InnerHtml += "You have recieved a bundle of 3! That's"  + " ticket(s)! </br>";
                        }
                        else if (Ticket_Num >= 301)
                        {
                            // bundle of 4
                            tickets_summary.InnerHtml += "You have recieved a bundle of 4! That's" + " ticket(s)! </br>";
                        }
                    }
                    // OUTPUT THE TOTAL TICKET NUMBER WITH THE TOTAL COST
                    tickets_summary.InnerHtml += "Your total ticket(s) is " + Ticket_Num + " and your cost is: " + (Ticket_Num * .25) + "cad!";
                }
            }
        }
    }
}