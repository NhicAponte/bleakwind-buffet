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
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }
        [BindProperty(SupportsGet = true)]
        public string[] Categories { get; set; }

        [BindProperty(SupportsGet = true)]
        public uint? CalMin { get; set; } = 0;
        [BindProperty(SupportsGet = true)]
        public uint? CalMax { get; set; } = 1000;

        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; } = 0;
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; } = 20;
        public void OnGet()
        {
            MenuItems = Menu.All;
            //SearchTerms = Request.Query["SearchTerms"];
            //Categories = Request.Query["Categories"];

            //MenuItems = Menu.Search(SearchTerms);
            if (SearchTerms != null)
            {
                MenuItems = MenuItems.Where(item => item.Name.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }
            //MenuItems = Menu.FilterByCategory(MenuItems, Categories);
            if(Categories != null && Categories.Length != 0)
            {
                MenuItems = MenuItems.Where(item => Categories.Contains(item.Category));
            }
            //MenuItems = Menu.FilterByCalories(MenuItems, CalMin, CalMax);
            if(CalMin == null) { CalMin = 0; }
            if(CalMax == null) { CalMax = 1000; }
            MenuItems = MenuItems.Where(item => item.Calories >= CalMin && item.Calories <= CalMax);
            //MenuItems = Menu.FilterByPrice(MenuItems, PriceMin, PriceMax);
            if (PriceMin == null) { PriceMin = 0; }
            if (PriceMax == null) { PriceMax = 20; }
            MenuItems = MenuItems.Where(item => item.Price >= PriceMin && item.Price <= PriceMax);
        }
    }
}
