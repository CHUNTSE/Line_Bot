using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Line_Bot
{
    public partial class Test001 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("5lge7swDAjesJbmSnQxKj0a9KKqRaskaBoRj+6xolErwWGl5czOsifb6/SfkitWRBeVYnnlbNi8pp2fFKwDgUkd5fUNbBOCl2tiX9o3AD50Ey5UG0I8no4JEDj9AWt4sH9heYqIlFpo2l/EBevP0BgdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("Ufde6e97e7e067d79f0bf4ddf2fe2c230", "test");
            bot.PushMessage("Ufde6e97e7e067d79f0bf4ddf2fe2c230", 1,2);
            bot.PushMessage("Ufde6e97e7e067d79f0bf4ddf2fe2c230",new Uri("https://farm4.staticflickr.com/3795/9269794168_3ac58fc15c_b.jpg"));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("5lge7swDAjesJbmSnQxKj0a9KKqRaskaBoRj+6xolErwWGl5czOsifb6/SfkitWRBeVYnnlbNi8pp2fFKwDgUkd5fUNbBOCl2tiX9o3AD50Ey5UG0I8no4JEDj9AWt4sH9heYqIlFpo2l/EBevP0BgdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("Ufde6e97e7e067d79f0bf4ddf2fe2c230",DateTime.Now.ToString());
            bot.PushMessage("Ufde6e97e7e067d79f0bf4ddf2fe2c230", 1, 104);
        }
    }
}