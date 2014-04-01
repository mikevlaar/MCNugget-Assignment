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
            program.readInput();

            Console.ReadLine();
        }

        /* This method calculates the amount of boxes of each type are required to package all the nuggets.
         * @param numberOfNuggets :The number of nuggets that need packaging.
         */
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

        /* This method reads the user input and starts the MCNugget calculation.
         */
        public void readInput()
        {
            Console.Write("Enter the amount of nuggets: ");
            string input = Console.ReadLine();
            int numberOfNuggets;

            bool result = Int32.TryParse(input, out numberOfNuggets);
            if (result && numberOfNuggets != 1 && numberOfNuggets != 2 && numberOfNuggets != 3 && numberOfNuggets != 5 && numberOfNuggets != 7 && numberOfNuggets != 11)
            {
                calculateMCNuggets(numberOfNuggets);
            }
            else
            {
                Console.WriteLine("The input is incorrect or is a number that can't be boxed!");
            }
            readInput();
        }
    }
}
