﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
	public class Product
	{
		[Key]
		public int ProductId { get; set; }

		public string ProductName { get; set; } = string.Empty;
	}
}
