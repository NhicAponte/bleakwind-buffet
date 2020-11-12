using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Windows.Controls.Ribbon.Primitives;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public IEnumerable<IOrderItem> MenuItems { get; set; }
        public string SearchTerms { get; set; }
        public string[] Categories { get; set; }

        [BindProperty(SupportsGet = true)]
        public uint CalMin { get; set; } = 0;
        [BindProperty(SupportsGet = true)]
        public uint CalMax { get; set; } = 1000;

        [BindProperty(SupportsGet = true)]
        public double PriceMin { get; set; } = 0;
        [BindProperty(SupportsGet = true)]
        public double PriceMax { get; set; } = 20;
        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
            Categories = Request.Query["Categories"];

            MenuItems = Menu.Search(SearchTerms);
            MenuItems = Menu.FilterByCategory(MenuItems, Categories);
            MenuItems = Menu.FilterByCalories(MenuItems, CalMin, CalMax);
            MenuItems = Menu.FilterByPrice(MenuItems, PriceMin, PriceMax);
        }
    }
}
