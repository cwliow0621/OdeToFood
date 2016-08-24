using OdeToFood.Entities;
using System.Collections.Generic;

namespace OdeToFood.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Restaurant> Restaurant { get; set; }
        public string CurrentGreeting { get; set; }

    }
}
