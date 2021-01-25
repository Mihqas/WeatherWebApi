using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherWebApi
{
    public class WeatherInfo
    {
        
        public class weather
        {
            
            public string main { get; set; }
            
            public string description { get; set; }
           
            public string icon { get; set; }
        }
        
        public class main
        {
            
            public double temp { get; set; }
            
            public double feels_like { get; set; }
            
            public double temp_min { get; set; }
            
            public double temp_max { get; set; }
            
            public double humidity { get; set; }
        }
        
        public class sys
        {
            
            public string country { get; set; }

        }
        
        public class wind
        {
            
            public double speed { get; set; }

        }
        
        public class clouds
        {
           
            public double all { get; set; }

        }
        
        public class root
        {
            
            public string name { get; set; }
           
            public double dt { get; set; }
            
            public sys sys { get; set; }
           
            public clouds clouds { get; set; }
           
            public wind wind { get; set; }
            
            public main main { get; set; }
            
            public List<weather> weather { get; set; }
        }
    }
}