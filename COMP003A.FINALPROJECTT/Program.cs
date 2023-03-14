using System;
using System.Drawing;
using System.Transactions;

namespace _003A.FInalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asking for userinput for first name
            string First;
            Console.Write("Enter First Name: ");
            First = Console.ReadLine();

            //Userintput last name
            string Last;
            Console.Write("Enter Last Name: ");
            Last = Console.ReadLine();

            //userinput age
            string age;
            Console.Write("Enter Birth Year: ");
            age = Console.ReadLine();
            int number = Convert.ToInt32(age);
            int winner = ageUser(number);

            ///userinput gender
            string gender;
            Console.WriteLine("Please Enter Gender: (M, F, O)");
            gender = Console.ReadLine();
            char genda = Convert.ToChar(gender);

            //questions 1-10 for user to answer
            string q1;
            Console.WriteLine("Question 1: Do you take meds");
            q1 = Console.ReadLine();

            string q2;
            Console.WriteLine("Question 2: Do you play any sports");
            q2 = Console.ReadLine();

            string q3;
            Console.WriteLine("Question 3: Have you had any serious injuries");
            q3 = Console.ReadLine();

            string q4;
            Console.WriteLine("Question 4: How tall are you");
            q4 = Console.ReadLine();

            string q5;
            Console.WriteLine("Question 5: How much do you weigh");
            q5 = Console.ReadLine();

            string q6;
            Console.WriteLine("Question 6: Do you drink a lot of water");
            q6 = Console.ReadLine();

            string q7;
            Console.WriteLine("Question 7: Have you smoked");
            q7 = Console.ReadLine();

            string q8;
            Console.WriteLine("Question 8: Have you drank alcohol");
            q8 = Console.ReadLine();

            string q9;
            Console.WriteLine("Question 9: Have you ever passed out?");
            q9 = Console.ReadLine();

            string q10;
            Console.WriteLine("Question 10: Has blood ever come out while you were peeing?");
            q10 = Console.ReadLine();


            PrintSelector("SUMMARY");
            Console.Write("\n");//breaking the line
            userName(Last, First);//displaying the user input last name and first name
            Console.Write(winner);
            Console.Write("\n");
            gen(genda);

            ///List of questions i put for users to answer 
            List<string> questions = new List<string>();

            questions.Add("Question 1: Do you take meds");
            questions.Add($"    Response 1: {q1}");
            questions.Add("Question 2: Do you play any sports");
            questions.Add($"    Response 2: {q2}");
            questions.Add("Question 3: Have you had any serious injuries");
            questions.Add($"    Response 3: {q3}");
            questions.Add("Question 4: How tall are you");
            questions.Add($"    Response 4: {q4}");
            questions.Add("Question 5: How much do you weigh");
            questions.Add($"    Response 5: {q5}");
            questions.Add("Question 6: Do you drink a lot of water");
            questions.Add($"    Response 6: {q6}");
            questions.Add("Question 7: Have you smoked");
            questions.Add($"    Respose 7: {q7}");
            questions.Add("Question 8: Have you drank alcohol");
            questions.Add($"    Response 8: {q8}");
            questions.Add("Question 9: Have you ever passed out?");
            questions.Add($"    Response 9: {q9}");
            questions.Add("Question 10: Has blood ever come out while you were peeing?");
            questions.Add($"    Response 10: {q10}");

            ///displaying the list of the questions and user response
            foreach (string item in questions)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Putting the user response in a sentence with this method
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        static void userName(string lastName, string firstName)
        {
            Console.WriteLine($"Full Name:{lastName}, {firstName}");
        }

        /// <summary>
        /// Getting the users age by getting the users birth year and subtracting it with the current year (2023)
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static int ageUser(int year)
        {
            if (year >= 2023)
            {
                Console.WriteLine("Invalid Age");
            }
            else if (year < 1900)
            {
                Console.WriteLine("Invalid Age");
            }
            return 2023 - year;
        }

        /// <summary>
        /// Getting the user input gender by using a if else loop based if the user enters M, F, or O
        /// </summary>
        /// <param name="gender"></param>
        static void gen(char gender)
        {
            if (gender == 'M')
            {
                Console.WriteLine("Gender: Male");
            }
            else if (gender == 'F')
            {
                Console.WriteLine("Gender: Female");
            }
            else if (gender == 'O')
            {
                Console.WriteLine("Others not listed");
            }
            else
            {
                Console.WriteLine("Invalid gender");
            }
        }

        static void PrintSelector(string shape)
        {
            Console.WriteLine($"**************************************************");
        }

    }
}