namespace WeatherApp.Model
{
    public class WeatherModel
    {
        public Location Location { get; set; }
        public Current Current { get; set; }
        public Request Request { get; set; }
    }
    public class Request
    {
        public string Query { get; set; }
    }
    public class Location
    {
        public string Lat { get; set; }
        public string Lon { get; set; }
    }

    public class Current
    {
        public string Temperature { get; set; }
        public string Is_day { get; set; }
        public string Wind_speed { get; set; }
        public string[] Weather_descriptions { get; set; }
        public string Observation_time { get; set; }
    }

    public class City
    {
        public string Name { get; set; }
    }
}
