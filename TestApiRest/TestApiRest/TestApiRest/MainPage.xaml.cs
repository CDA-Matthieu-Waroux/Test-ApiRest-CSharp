using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApiRest
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            
		}

        public void Frankouille()
        {

            string url = "https://api.coinmarketcap.com/v1/ticker/";

            using (var client = new WebClient())
            {
                var json = client.DownloadString(url);
                var donnee = JsonConvert.DeserializeObject<List<RootObject>>(json);
               
                foreach(var frankencouille in donnee)
                {
                    LabelNom.Text = frankencouille.name;


                }

            }
        
        }
	}
}
