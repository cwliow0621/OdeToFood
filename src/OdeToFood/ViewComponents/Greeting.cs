using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Services;

namespace OdeToFood.ViewComponents
{
    public class Greeting : ViewComponent
    {
        private IGreeter _greeter;

        public Greeting(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            await Task.Delay(1);
            var model = _greeter.GetGreeting();
            return View("Default",model);
        }
    }
}
