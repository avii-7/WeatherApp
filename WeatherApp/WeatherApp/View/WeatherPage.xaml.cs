using System;
using WeatherApp.Api;
using WeatherApp.Model;
using WeatherApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            BindingContext = new WeatherViewModel();
        }
        private async void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker Item = (Picker)sender;
            int index = Item.SelectedIndex;
            if (index != -1)
            {
                string name = Item.Items[index];
                WeatherModel data = await WeatherApi.GetWeatherData(name);
                DisplayData(data);
            }
        }

        private void DisplayData(WeatherModel data)
        {
            if (!string.IsNullOrEmpty(data.Current.Temperature))
            {
                Temp.Text = data.Current.Temperature;
                Location.Text = data.Request.Query;
                Description.Text = data.Current.Weather_descriptions[0];
                O_Time.Text = data.Current.Observation_time;
                LatAndLong.Text = data.Location.Lat + ", " + data.Location.Lon;
                WindSpeed.Text = data.Current.Wind_speed + " Km/h";
                string val = data.Current.Is_day;
                IsDay.Text = val.ToUpper();
                IsDay_icon.Source = val.Equals("yes") ? "day" : "night";
            }
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
