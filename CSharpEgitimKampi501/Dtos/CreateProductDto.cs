﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Dtos
{
	public class CreateProductDto
	{
		public string ProductName { get; set; }
		public string ProdcutCategory { get; set; }
		public int ProductStock { get; set; }
		public decimal ProductPrice { get; set; }
	}
}
