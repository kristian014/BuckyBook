using System;
using BuckyBook.Models;

namespace BuckyBook.ViewModels
{
	public class OrderVM
	{
		public OrderVM()
		{
		}

		public OrderHeader OrderHeader { get; set; }

		public IEnumerable<OrderDetail> OrderDetail { get; set; }
	}
}

