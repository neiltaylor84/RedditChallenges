using System;

namespace challenge110515
{
	class MainClass
	{
		public static double GetMean(double s, double l)
		{
			return s / l;
		}

		public static double GetStdDev(double m, double[] n) 
		{
			double stdDev = 0.0;
			double sum = 0;
			double[] values = new double[n.Length];
			for (int i = 0; i < n.Length; i++)
			{
				values[i] = (n[i] - m) * (n[i] - m);
				sum += values[i];
			}
			stdDev = sum / n.Length;
			return Math.Round(Math.Sqrt(stdDev), 4);
		}

		static void Main(string[] args)
		{
			double stdDev = 0.0;
			double mean = 0;
			double sum = 0;

			//list of numbers given as test input
			double[] numbers = new double[] {809, 816, 833, 849, 851, 961, 976, 1009, 1069, 1125, 1161, 1172, 1178, 1187, 1208, 1215, 1229, 1241, 1260, 1373};

			for (int i = 0; i < numbers.Length; i++)
			{
				sum += numbers[i];
			}

			mean = GetMean(sum, numbers.Length);

			stdDev = GetStdDev(mean, numbers);

			Console.WriteLine("The standard Deviation of the numbers is : {0}" , stdDev);

		}       
	}
}
