using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
	public class rectangle
	{
		public double basis;
		public double height;

		public double Area()
		{

			Double Area = this.basis * this.height;
			return Area;
		}

		public double perimeter()
		{
			double perim = this.basis + this.basis + this.height;
			return perim;
		}

		public void Grow(double quantity)
		{

			this.basis = this.basis + quantity;
			this.height = this.height + quantity;
		}

		public double Compare(rectangle rect)
		{

			return this.Area() - rect.Area();
		}



		
		}
	}
}

