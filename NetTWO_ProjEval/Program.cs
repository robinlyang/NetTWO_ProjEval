using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetTWO_ProjEval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Interest Rate: ");
            double interestRate = Convert.ToDouble(Console.ReadLine());
            double interrestRateMultiplier = (interestRate / 100) + 1;
            Console.Write("Enter Cost: ");
            double cost = Convert.ToDouble(Console.ReadLine());
            double negativeCost = cost * -1;
            Console.Write("Enter Revenue & Years: ");
            string source = Console.ReadLine();
            string[] stringSeparators = new string[] { "," };
            string[] result;
            result = source.Split(stringSeparators, StringSplitOptions.None);
            int years = 0;
            List<double> revenueList = new List<double>();
            double[] revenueArray = new double[result.Length];
            List<double> yearList = new List<double>();
            double[] yearArray = new double[result.Length];

            for(int x = 0; x < result.Length; x++)
            {
                if(x % 2 != 0)
                {
                    years = years + Convert.ToInt32(result[x]);
                    yearList.Add(Convert.ToDouble(result[x]));
                }
                else
                {
                    revenueList.Add(Convert.ToDouble(result[x]));
                }
            }
            //TESTING
            for(int x = 0;x<yearArray.Length/2;x++)
            {
                Console.WriteLine("Revenue: " + revenueList[x] + " TO Years: " + yearList[x]);  
            }
            //CALCULATE REVENUE
            double revenue = 0.0;
            for(int x = 0; x < yearList.Count; x++)
            {
                double revYear = yearList[x];
                for(int y = 0; y < revYear; y++)
                {
                    revenue = revenue + (revenueList[x]/ interrestRateMultiplier);
                }
            }

            Console.WriteLine("PROJECT EVALUATION");
            Console.WriteLine("INTEREST RATE: " + interestRate.ToString("##.###"));
            Console.WriteLine("COST: " + cost.ToString("$##,###,###"));
            Console.WriteLine("REVENUE: " + (revenue + negativeCost).ToString("#.##"));
            Console.WriteLine("# OF YEARS: " + years.ToString("##"));
            Console.ReadLine();
        }
    }
}
