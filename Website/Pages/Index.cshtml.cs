using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {

        /// <summary>
        /// the items
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; } = Menu.All;
 

        /// <summary>
        /// The current search terms 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// The filtered Category
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] Category { get; set; }


        /// <summary>
        /// The minimum Calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// The maximum Calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// The minimum Calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        /// <summary>
        /// The maximum Calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        /// <summary>
        /// on get 
        /// </summary>
        public void OnGet()
        {
            Items = Menu.Search(Items,SearchTerms);
            Items = Menu.FilterByCategory(Items, Category);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }

        /// <summary>
        /// on post
        /// </summary>
        public void OnPost()
        {
            Items = Menu.Search(Items, SearchTerms);
            Items = Menu.FilterByCategory(Items, Category);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }
    }
}
