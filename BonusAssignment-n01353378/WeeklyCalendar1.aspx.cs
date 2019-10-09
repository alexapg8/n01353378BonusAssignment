using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment_n01353378
{
    public partial class WeeklyCalendar1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack)
            {

                Page.Validate();

                if (Page.IsValid)
                {
                    weeklyworkcalendar_summary.InnerHtml = "";
                    weeklyworkcalendar_summary.InnerHtml += "Here is your schedule for October: </br>";
                    // int count = 0;
                    // COUNT FROM 1 TO 31 AS THE DAYS IN OCTOBER
                    //string day = " ";
                    for (int i = 1; i <= 31; i++)
                    {
                        //day += "Oct " + i.ToString();

                        foreach (ListItem work_days in work_days.Items)
                        {
                            // THE OUTPUT SHOULD SHOW THE NUMBER OF THE DAY IN THE MONTH AS WELL AS THE NAME WITH THE TEXT " TIME TO STUDY".
                            if (work_days.Selected == true)
                            {
                                // IF THE USER CHECKS A BOX, THEN WE CHECK WHICH BOXES THEY CHOSE
                                // PRINT OUT THE DAY NUMBER DEPENDING ON THE FOR LOOP WE CREATED  WITH THE NAME
                                // HOW TO GET LOOP TO ONLY SHOW THE NUMBERS THAT ARE CORRECT ACCORDING TO OUR IF STATEMENT.
                                if (work_days.Value == "monday" && (i%7)==0)
                                {
                                    weeklyworkcalendar_summary.InnerHtml += "Oct " + i + " is a " + work_days.Value + "! time to study!<br>";
                                }
                                else if (work_days.Value == "tuesday" && (i % 7) == 1)
                                {
                                    weeklyworkcalendar_summary.InnerHtml += "Oct " + i + " is a " + work_days.Value + "! time to study!<br>";
                                }
                                else if (work_days.Value == "wednesday" && (i % 7) == 2)
                                {
                                    weeklyworkcalendar_summary.InnerHtml += "Oct " + i + " is a " + work_days.Value + "! time to study!<br>";
                                }
                                else if (work_days.Value == "thursday" && (i % 7) == 3)
                                {
                                    weeklyworkcalendar_summary.InnerHtml += "Oct " + i + " is a " + work_days.Value + "! time to study!<br>";
                                }
                                else if (work_days.Value == "friday" && (i % 7) == 4)
                                {
                                    weeklyworkcalendar_summary.InnerHtml += "Oct " + i + " is a " + work_days.Value + "! time to study!<br>";
                                }
                                else if (work_days.Value == "saturday" && (i % 7) == 5)
                                {
                                    weeklyworkcalendar_summary.InnerHtml += "Oct " + i + " is a " + work_days.Value + "! time to study!<br>";
                                }
                                else if (work_days.Value == "sunday" && (i % 7) == 6)
                                {
                                    weeklyworkcalendar_summary.InnerHtml += "Oct " + i + " is a " + work_days.Value + "! time to study!<br>";
                                }
                            }
                            // IF THE USER DOES NOT SELECT A DAY, THEN THE MESSAGE SHOULD SAY "TIME TO HAVE FUN".
                            else
                            {
                                if (work_days.Value == "monday" && (i % 7) == 0)
                                {
                                    weeklyworkcalendar_summary.InnerHtml += "Oct " + i + " is a " + work_days.Value + "! time to have fun!<br>";
                                }
                                else if (work_days.Value == "tuesday" && (i % 7) == 1)
                                {
                                    weeklyworkcalendar_summary.InnerHtml += "Oct " + i + " is a " + work_days.Value + "! time to have fun!<br>";
                                }
                                else if (work_days.Value == "wednesday" && (i % 7) == 2)
                                {
                                    weeklyworkcalendar_summary.InnerHtml += "Oct " + i + " is a " + work_days.Value + "! time to have fun!<br>";
                                }
                                else if (work_days.Value == "thursday" && (i % 7) == 3)
                                {
                                    weeklyworkcalendar_summary.InnerHtml += "Oct " + i + " is a " + work_days.Value + "! time to have fun!<br>";
                                }
                                else if (work_days.Value == "friday" && (i % 7) == 4)
                                {
                                    weeklyworkcalendar_summary.InnerHtml += "Oct " + i + " is a " + work_days.Value + "! time to have fun!<br>";
                                }
                                else if (work_days.Value == "saturday" && (i % 7) == 5)
                                {
                                    weeklyworkcalendar_summary.InnerHtml += "Oct " + i + " is a " + work_days.Value + "! time to have fun!<br>";
                                }
                                else if (work_days.Value == "sunday" && (i % 7) == 6)
                                {
                                    weeklyworkcalendar_summary.InnerHtml += "Oct " + i + " is a " + work_days.Value + "! time to have fun!<br>";
                                }
                            }
                        }
                        //weeklyworkcalendar_summary.InnerHtml += i;
                    }
                }
            }
        }
    }
}

