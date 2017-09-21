using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;

namespace ParticlePhotonLED
{
    public class App : Application
    {
        public App()
        {
			var ChangeLedCommandOn = new Command<string>(ledOn);
			var ChangeLedCommandOff = new Command<string>(ledOff);
            var onButton = new Button{ Text = "ON", Command=ChangeLedCommandOn };
            var offButton = new Button { Text = "OFF", Command=ChangeLedCommandOff };
			
			// The root page of your application
			var content = new ContentPage
            {
                Title = "ParticlePhotonLED",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Welcome to being able to control Particle Photon using Xamarin Forms!"
						}, 
                        onButton, 
                        offButton
                    }
                }
            };

            MainPage = new NavigationPage(content);
        }

        public void ledOn(string changeValue="on")
        {
            changeValue = "on";
            string accessToken = "e54ec36b6b139319129d8cd075cb88f095a9dce7"; //This is your Particle Cloud Access Token
            string deviceId = "28003d001847343338333633"; //This is your Particle Device Id
            string partilceFunc = "led"; //This is the name of your Particle Function

            HttpClient client = new HttpClient
            {
                BaseAddress =
                new Uri("https://api.particle.io/")
            };

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("access_token", accessToken),
                new KeyValuePair<string, string>("args", changeValue )
            });

            var result = client.PostAsync("v1/devices/" + deviceId + "/" + partilceFunc, content);
        }
		public void ledOff(string changeValue = "off")
		{
			changeValue = "off";
			string accessToken = "e54ec36b6b139319129d8cd075cb88f095a9dce7"; //This is your Particle Cloud Access Token
			string deviceId = "28003d001847343338333633"; //This is your Particle Device Id
			string partilceFunc = "led"; //This is the name of your Particle Function

			HttpClient client = new HttpClient
			{
				BaseAddress =
				new Uri("https://api.particle.io/")
			};

			var content = new FormUrlEncodedContent(new[]
			{
				new KeyValuePair<string, string>("access_token", accessToken),
				new KeyValuePair<string, string>("args", changeValue )
			});

			var result = client.PostAsync("v1/devices/" + deviceId + "/" + partilceFunc, content);
		}

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
