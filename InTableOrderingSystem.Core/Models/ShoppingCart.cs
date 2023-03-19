using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InTableOrderingSystem.Core.Models
{
	public class ShoppingCart
	{
		public int Id { get; set; }

		public int MenuItemId { get; set; }

		[ValidateNever]
		[ForeignKey("MenuItemId")]
		public MenuItem MenuItem { get; set; }

		[Range(1, 100, ErrorMessage = "Please select a count between 1 and 100")]
		public int Count { get; set; } = 1;

		public string ApplicationUserId { get; set; }

		[ValidateNever]
		[ForeignKey("ApplicationUserId")]
		public ApplicationUser ApplicationUser { get; set; }
	}
}
