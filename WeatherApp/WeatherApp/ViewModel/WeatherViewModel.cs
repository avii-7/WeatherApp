using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Model;


namespace WeatherApp.ViewModel
{
    public class WeatherViewModel
    {
        public List<City> Cities { get; set; }
        public WeatherViewModel()
        {
            Cities = new List<City>()
            {
                new City()
                {
                    Name = "Ambala"
                },
                new City()
                {
                    Name = "Delhi"
                },
                new City()
                {
                    Name = "Bihar"
                },
                new City()
                {
                    Name = "Kashmir"
                },
                new City()
                {
                    Name = "Jagadhri"
                },
                new City()
                {
                    Name = "Yamunanagar"
                }
            };
        }
    }
}
