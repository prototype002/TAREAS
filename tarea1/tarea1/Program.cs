using System;

namespace rectangle
{
	class programa
	{
		static void Main(string[] args)
		{
			rectangle rentangle1 = new rectangle();
			rectangle.basis = 3;
			rectangle.height = 7;

			rectangle rentangle2 = new rectangle();
			rectangle.basis = (int)1.5;
			rectangle.height = 4;

			Console.WriteLine(rectangle1.Compare(rectangle2));


			Console.ReadKey();
			}
		}
	}
