using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
    class BerlinClockMain
    {
        public static void Main(string[] args) {
            TimeFormatCreator factory = new ConcreteTimeFormatCreator();

		    Console.WriteLine("Input Format Type:\n1. Simple ");
		    String inputTimeFormat = Console.ReadLine();
		    ITimeFormatFactory inputFormat = factory.setTimeFormat(inputTimeFormat);
				
			Console.WriteLine("Enter Time:");
			String t = Console.ReadLine();
			Time inputTime = inputFormat.setInput(t);
					
			Console.WriteLine("Output Format Type:\n1. Simple \n2. Berlin");
			String outputTimeFormat = Console.ReadLine();
			ITimeFormatFactory outputFormat = factory.getTimeFormat(outputTimeFormat);	
			Console.WriteLine("\nOutput Time:");
			Console.WriteLine(outputFormat.getOutput(inputTime));
        }
    }
}
