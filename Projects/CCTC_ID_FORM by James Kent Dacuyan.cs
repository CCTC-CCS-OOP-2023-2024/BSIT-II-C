using System;

namespace CCTC_ID_Form
{
    class Dacuyan
    {
        static void Main()
        {

            Console.WriteLine("Welcome To CCTC ID FORM");

            string studentName;
            int studentID;
            string course;


            int age = 19;
            int yearOfBirth = DateTime.Now.Year - age;

            int currentYear = DateTime.Now.Year;
            int graduationYear = currentYear + 4;

            studentName = "James Kent Dacuyan";
            studentID = 20231548;
            course = "Bachelor of Science in Information Technology (BSIT)";

            Console.Write("Enter your age: ");
            int userInputAge = Convert.ToInt32(Console.ReadLine());

            string welcomeMessage = "WELCOME TO\n\tCCTC ID FORM\n\tby James Kent Dacuyan";

            string studentInfo = "Student Name: " + studentName + "\nStudent ID: " + studentID + "\nCourse: " + course;

            if (userInputAge >= 18)
            {
                Console.WriteLine("You are eligible to apply for an ID.");
            }
            else
            {
                Console.WriteLine("You must be at least 18 years old to apply for an ID.");
            }

            bool hasCompletedOrientation = true;
            bool hasPaidFees = false;

            if (hasCompletedOrientation && hasPaidFees)
            {
                Console.WriteLine("You are ready to receive your ID.");
            }
            else
            {
                Console.WriteLine("Please complete orientation and pay fees to receive your ID.");
            }

            string yearLevel = "Sophomore";

            switch (yearLevel)
            {
                case "Freshman":
                    Console.WriteLine("You are in your first year.");
                    break;
                case "Sophomore":
                    Console.WriteLine("You are in your second year.");
                    break;

                default:
                    Console.WriteLine("Invalid year level");
                    break;
            }

            string status = (hasPaidFees) ? "Paid" : "Pending";

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Form Section: " + i);
            }

            int section = 1;
            while (section <= 3)
            {
                Console.WriteLine("While loop: Section " + section);
                section++;
            }

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                    break; 

                if (i % 2 == 0)
                    continue; 

                Console.WriteLine("Section: " + i);
            }

            DisplayWelcomeMessage(welcomeMessage);
            int birthYear = CalculateBirthYear(age);
            Console.WriteLine("Year of Birth: " + birthYear);

            
            PrintStudentInfo(studentName, studentID, course);

            
            int yearsUntilGraduation = CalculateYearsUntilGraduation(currentYear, graduationYear);
            Console.WriteLine("Years until graduation: " + yearsUntilGraduation);
        }

        static void DisplayWelcomeMessage(string message)
        {
            Console.WriteLine(message);
        }

        static int CalculateBirthYear(int currentAge)
        {
            return DateTime.Now.Year - currentAge;
        }

        static void PrintStudentInfo(string name, int id, string course)
        {
            Console.WriteLine("Student Information: Happy Person");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Course: " + course);
        }

        static int CalculateYearsUntilGraduation(int currentYear, int graduationYear)
        {
            return graduationYear - currentYear;
        }
    }
}