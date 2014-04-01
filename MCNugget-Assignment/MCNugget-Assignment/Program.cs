using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCNugget_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.calculateMCNuggets(31);
            Console.ReadLine();
        }

        public void calculateMCNuggets(int numberOfNuggets)
        {
            int numberOfSolutions = 0;
            for(int nOf4 = 0; nOf4 < numberOfNuggets; nOf4++)
            {
                for(int nOf6 = 0; nOf6 < numberOfNuggets; nOf6++)
                {
                    for(int nOf9 = 0; nOf9 < numberOfNuggets; nOf9++)
                    {
                        for(int nOf20 = 0; nOf20 < numberOfNuggets; nOf20++)
                        {
                            if(nOf4 * 4 + nOf6 * 6 + nOf9 * 9 + nOf20 * 20 == numberOfNuggets)
                            {
                                numberOfSolutions++;
                                Console.WriteLine("----------Solution " + numberOfSolutions + " ----------");
                                Console.WriteLine("Number of 4 nugget boxes: " + nOf4);
                                Console.WriteLine("Number of 6 nugget boxes: " + nOf6);
                                Console.WriteLine("Number of 9 nugget boxes: " + nOf9);
                                Console.WriteLine("Number of 20 nugget boxes: " + nOf20 + "\n");
                            }
                        }
                    }
                }
            }
        }
    }
}
