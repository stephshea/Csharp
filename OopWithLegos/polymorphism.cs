using System;

namespace Bulldozer
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			var worker = new factoryWorker();
			worker.Count(4);
			worker.Count(5);

			worker.Count(4.5f);
			worker.
		}
	}

	public class factoryWorker
	{
		public factoryWorker()
		{

		}

		public void Count (int number) {
            if(Total == Null)
				Total = 0;
			Total = Total + Convert.ToSingle(number);
			Console.WriteLine(Total.ToString());
        }

		public void Count(float number) {
			Total = Total + number;
			Console.WriteLine(Total.ToString());
			}

		public void Count(int num1, float num2, double num3)
        {

        }

        public float Total { get; set; }
    }
}