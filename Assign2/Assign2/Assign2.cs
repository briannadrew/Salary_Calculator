/* Author: Brianna Drew
Student ID: 0622446
Description: This is a program that computes the average salary of Canadian workers based on their education type (for Statistics Canada).

Data Dictionary (Variables):
 * edType: char variable that holds a worker's education type (the first letter).
 * salaryData: double variable that holds a worker's salary.
 * universityAvg: double variable that holds the average salary of the workers entered with a university education.
 * collegeAvg: double variable that holds the average salary of the workers entered with a college education.
 * highschoolAvg: double variable that holds the average salary of the workers entered with a high school education.
 * universityTotal: double variable that will hold the sum of all the marks of the workers entered with a university education.
 * collegeTotal: double variable that will hold the sum of all the marks of the workers entered with a college education.
 * highschoolTotal: double variable that will hold the sum of all the marks of the workers entered with a high school education. 
 * universityCount: int variable that will hold the number of workers entered with a university education.
 * collegeCount: int variable that will hold the number of workers entered with a college education.
 * highschoolCount: int variable that will hold the number of workers entered with a high school education. */

using System;
public static class Assign2
{
    public static void Main()
    {
        // defining the variables and their types.
        char edType = 'A';
        double salaryData = 1.0, universityAvg = 0.0, collegeAvg = 0.0, highschoolAvg = 0.0, universityTotal = 0.0, collegeTotal = 0.0, highschoolTotal = 0.0;
        int universityCount = 0, collegeCount = 0, highschoolCount = 0;

        // introduction to the program.
        Console.WriteLine("Welcome to the Statistics Canada Average Educated Worker Salary Calculator.");
        Console.WriteLine(" ");

        while (char.ToUpper(edType) != 'Q') // stay in this loop as long as the user doesn't enter the letter 'Q' for the edType.
        {
            // prompt the user to enter the worker's education type.
            Console.Write(@"Enter the Education Type of the worker (U for university degrees, C for college diplomas,
H for high school diplomas, or Q to quit): ");
            edType = Convert.ToChar(Console.ReadLine());
       
            // if the worker's education type is university.
            if (char.ToUpper(edType) == 'U')
            {
                do
                {
                    // prompt the user to enter the worker's salary.
                    Console.Write("Enter their salary: ");
                    salaryData = Convert.ToDouble(Console.ReadLine());
                    // if the salary entered is less than 0, it is invalid and they will continue to be prompted until they enter a valid entry.
                    if (salaryData < 0)
                        Console.Write("That is an invalid entry. Please try again.");
                        Console.WriteLine(" ");
                } while (salaryData < 0.0);

                // add 1 to the number of university level workers and add the salary to the total salary for the university level workers.
                universityCount++;
                universityTotal += salaryData;
            }

            // if the worker's education type is college.
            else if (char.ToUpper(edType) == 'C')
            {
                do
                {
                    // prompt the user to enter the worker's salary.
                    Console.Write("Enter their salary: ");
                    salaryData = Convert.ToDouble(Console.ReadLine());
                    // if the salary entered is less than 0, it is invalid and they will continue to be prompted until they enter a valid entry.
                    if (salaryData < 0)
                        Console.Write("That is an invalid entry. Please try again.");
                        Console.WriteLine(" ");
                } while (salaryData < 0.0);

                // add 1 to the number of college level workers and add the salary to the total salary for the college level workers.
                collegeCount++;
                collegeTotal += salaryData;
            }

            // if the worker's education type is high school.
            else if (char.ToUpper(edType) == 'H')
            {
                do
                {
                    // prompt the user to enter the worker's salary.
                    Console.Write("Enter their salary: ");
                    salaryData = Convert.ToDouble(Console.ReadLine());
                    // if the salary entered is less than 0, it is invalid and they will continue to be prompted until they enter a valid entry.
                    if (salaryData < 0)
                        Console.Write("That is an invalid entry. Please try again.");
                        Console.WriteLine(" ");
                } while (salaryData < 0.0);

                // add 1 to the number of high school level workers and add the salary to the total salary for the high school level workers.
                highschoolCount++;
                highschoolTotal += salaryData;
            }
            else if (char.ToUpper(edType) == 'Q')
            {
                // if the user enters the letter 'Q' for edType, exit this while loop.
                break;
            }
            else
            {
                // if the user enters any letter other than U, C, H, or Q for edType, that is invalid and they will continue to be prompted until they enter a valid entry.
                Console.Write("That is an invalid entry. Please try again.");
                Console.WriteLine(" ");
            }
            // set the worker salary to a negative to be able to run the do while loops.
            salaryData = -1.0;
        }

        // calculating the average salaries for each education type.
        if (universityCount > 0)
            universityAvg = universityTotal / universityCount;
        if (collegeCount > 0)
            collegeAvg = collegeTotal / collegeCount;
        if (highschoolCount > 0)
            highschoolAvg = highschoolTotal / highschoolCount;

        // final output (result statements).
        Console.WriteLine(" ");
        Console.WriteLine("Average salary of workers with university degrees: {0:C}", universityAvg);
        Console.WriteLine("Average salary of workers with college diplomas: {0:C}", collegeAvg);
        Console.WriteLine("Average salary of workers with high school diplomas: {0:C}", highschoolAvg);

        Console.ReadLine();
    }
}