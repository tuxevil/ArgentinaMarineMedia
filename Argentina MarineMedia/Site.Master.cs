using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace Argentina_MarineMedia
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XDocument upcomingEvents = XDocument.Load(Server.MapPath("~/UpcomingEvents.xml"));
            List<XElement> events = new List<XElement>(from item in upcomingEvents.Descendants("UpcomingEvents").Descendants("Event")
                                                       where new DateTime(Convert.ToInt32(item.Element("EndDate").Value.Split('-')[0]), Convert.ToInt32(item.Element("EndDate").Value.Split('-')[1]), Convert.ToInt32(item.Element("EndDate").Value.Split('-')[2])) >= DateTime.Today
                               select item);
            
            string upcomignEvents = string.Empty;

            if(events.Count > 2)
            {
                upcomignEvents += "<marquee direction=\"up\" width=200 height=315 scrolldelay=\"150\">";
            }
            foreach (XElement element in events)
            {
                string tempEvent = string.Empty;
                tempEvent += "<div class=\"upcomingEventItem\"><span class=\"upcomingEventItemName\">";
                tempEvent += element.Element("Name").Value;
                tempEvent += "</span><span class=\"upcomingEventItemInfo\">";
                tempEvent += element.Element("Description").Value;
                tempEvent += "<br />";
                tempEvent += element.Element("Location").Value;
                tempEvent += "<br />";
                DateTime startDate = new DateTime(Convert.ToInt32(element.Element("StartDate").Value.Split('-')[0]), Convert.ToInt32(element.Element("StartDate").Value.Split('-')[1]), Convert.ToInt32(element.Element("StartDate").Value.Split('-')[2]));
                tempEvent += startDate.ToShortDateString();
                tempEvent += " - ";
                DateTime endDate = new DateTime(Convert.ToInt32(element.Element("EndDate").Value.Split('-')[0]), Convert.ToInt32(element.Element("EndDate").Value.Split('-')[1]), Convert.ToInt32(element.Element("EndDate").Value.Split('-')[2]));
                tempEvent += endDate.ToShortDateString();
                tempEvent += "</span></div>";

                upcomignEvents += tempEvent;
            }
            if (events.Count > 2)
            {
                upcomignEvents += "</marquee>";
            }
            UpcomingEvents.Text = upcomignEvents;
        }
    }
}
