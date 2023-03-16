/*
  * Author: Xavier Leftridge
  * Course: COMP-003A
  * Purpose: Final revision
  * 
 */

using Microsoft.VisualBasic;

namespace _003A.FInalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Patient Form!");
            Console.WriteLine("\n");

            //asking for userinput for first name
            string firstName;
            Console.Write("Enter First Name: ");
            firstName = Console.ReadLine();

            //Userintput last name
            string lastName;
            Console.Write("Enter Last Name: ");
            lastName = Console.ReadLine();


            //userinput age
            int ageInput;
            Console.WriteLine("Enter birth year: ");
            ageInput = Convert.ToInt32(Console.ReadLine());
            int ageOutput = Ageuser(ageInput);
            

            ///userinput gender
            string genderUser;///assinging user input to a variable 
                Console.WriteLine("Please Enter Gender: (M, F, O)");
                genderUser = Console.ReadLine();
                char genderInput = Convert.ToChar(genderUser);

                var questions = new List<string>(); ///creating list of questions

                questions.Add($"Question 1: Do you take meds");

                questions.Add("Question 2: Do you play any sports");

                questions.Add("Question 3: Have you had any serious injuries");

                questions.Add("Question 4: How tall are you");

                questions.Add("Question 5: How much do you weigh");

                questions.Add("Question 6: Do you drink a lot of water");

                questions.Add("Question 7: Have you smoked");

                questions.Add("Question 8: Have you drank alcohol");

                questions.Add("Question 9: Have you ever passed out?");

                questions.Add("Question 10: Has blood ever come out while you were peeing?");

                var responses = new List<string>(); ///list of responses

            foreach (var question in questions) ///assiging the responses to the questions
            {
                Console.WriteLine(question);
                
                    
                
                responses.Add(Console.ReadLine());
            }

            Console.Write("SUMMARY");
            Console.Write("\n");//breaking the line
            Username(lastName, firstName);//displaying the user input last name and first name
            Console.WriteLine(ageOutput); ///age output
            Genderinput(genderInput);//calling the gender user input
            for (int i = 0; i < questions.Count; i++) ///calling the questions/ response using a for statement
            {
                Console.WriteLine(questions[i]);
                Console.WriteLine(responses[i]);
            }

            /// <summary>
            /// Putting the user response in a sentence with this method
            /// </summary>
            /// <param name="lastName"></param>
            /// <param name="firstName"></param>
            static void Username(string lastName, string firstName)
                {
                    Console.WriteLine($"Full Name:{lastName}, {firstName}");
                }

                /// <summary>
                /// Getting the users age by getting the users birth year and subtracting it with the current year (2023)
                /// </summary>
                /// <param name="year"></param>
                /// <returns></returns>





                /// <summary>
                /// Getting the user input gender by using a if else loop based if the user enters M, F, or O
                /// </summary>
                /// <param name="gender"></param>
                static void Genderinput(char gender)
                {
                    if (gender == ' ')
                    {
                        Console.WriteLine("Please re-enter age");
                    }
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


           
            /// <summary>
            /// Calculating the users age input and validating it to make sure they cant enter anything wrong
            /// </summary>
            /// <param name="year"></param>
            static int Ageuser(int year)
            {
                bool isValid = false;
                do
                {
                    Console.WriteLine("Enter Birth Year");

                    try
                    {
                        year = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Input!");
                        continue;
                    }

                    if (year <= 1900 || year >= 2030)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    else
                    {
                        isValid = true;
                    }
                } while(!isValid);
                return 2023 - year;
            }


        }
    }
}