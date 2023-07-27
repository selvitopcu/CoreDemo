using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Models
{
	public class CityViewModel
	{
		public string City { get; set; }
		public IList<SelectListItem> Cities { get; set; }
	}
}
