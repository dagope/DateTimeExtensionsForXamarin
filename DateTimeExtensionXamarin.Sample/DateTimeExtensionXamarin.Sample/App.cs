using DateTimeExtensionsXamarin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DateTimeExtensionXamarin.Sample
{
    public class App : Application
    {
        public App()
        {
            Random r = new Random();
            DateTime dtFutureOneYear = DateTime.Now.AddDays(r.Next(365, 365*2));

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                         new Label { Text = "Samples DateTimeExtensions for Xamarin:" , FontSize=20}
                        ,new Label { Text = "Future Date (dd/MM/yyyy hh:mm:ss):" , FontAttributes= FontAttributes.Bold}
                        ,new Label { Text = dtFutureOneYear.ToString("dd/MM/yyyy hh:mm:ss") }

                        ,new Label { Text = "ToExactNaturalText:" + dtFutureOneYear.ToString("dd/MM/yyyy hh:mm:ss") , FontAttributes= FontAttributes.Bold}
                        ,new Label { Text = dtFutureOneYear.ToExactNaturalText(DateTime.Now) }

                        ,new Label { Text = "ToExactNaturalText (es-ES):" , FontAttributes= FontAttributes.Bold}
                        ,new Label { Text = dtFutureOneYear.ToExactNaturalText(DateTime.Now,  new DateTimeExtensionsXamarin.NaturalText.NaturalTextCultureInfo("es-ES")) }

                        ,new Label { Text = "ToNaturalText:" , FontAttributes= FontAttributes.Bold}
                        ,new Label { Text = dtFutureOneYear.ToNaturalText(DateTime.Now) }

                        ,new Label { Text = "ToNaturalText (es-ES):" , FontAttributes= FontAttributes.Bold}
                        ,new Label { Text = dtFutureOneYear.ToNaturalText(DateTime.Now,  new DateTimeExtensionsXamarin.NaturalText.NaturalTextCultureInfo("es-ES")) }
                    }
                }
            };
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
