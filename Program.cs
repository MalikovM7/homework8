using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;

namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Task7();

        }

        static void Task1()
        {

            Console.WriteLine("Bir eded daxil edin");
        l1:
            string aStr = Console.ReadLine();

            bool state = int.TryParse(aStr, out int num);

            if (!state)
            {

                Console.WriteLine("Ededi yeniden daxil edin");

                goto l1;


            }

            if (num % 2 == 0)
            {
                Console.WriteLine("Verilmish eded cut dur");

            }
            else
            {

                Console.WriteLine("Verilmish eded tekdir");


            }





        }


        static void Task2()
        {

            Console.WriteLine("A ededin daxil edin");
        l1:
            string aStr = Console.ReadLine();

            Console.WriteLine("B ededin daxil edin");

        l2:
            string bStr = Console.ReadLine();

            bool state = int.TryParse(aStr, out int num);

            bool state2 = int.TryParse(bStr, out int num2);

            if (!state)
            {

                Console.WriteLine("A Ededi yeniden daxil edin");

                goto l1;


            }

            if (!state2)
            {
                Console.WriteLine("B Ededi yeniden daxil edin");

                goto l2;




            }

            else
            {

                if (num % num2 == 0)
                {
                    Console.WriteLine(num / num2);



                }

                else
                {

                    Console.WriteLine("Eded bolunmur");


                }






            }





        }



        static void Task3()
        {

            Console.WriteLine("Bir eded daxil edin");
        l1:
            string aStr = Console.ReadLine();

            bool state = int.TryParse(aStr, out int num);

            if (!state)
            {

                Console.WriteLine("Ededi yeniden daxil edin");

                goto l1;


            }

            else
            {
                if (num % 10 == 7)
                {


                    Console.WriteLine("Beli");



                }

                else
                {
                    Console.WriteLine("Xeyr");


                }





            }




        }


        static void Task4()
        {

            Console.WriteLine("A ededin daxil edin");
        l1:
            string aStr = Console.ReadLine();

            Console.WriteLine("B ededin daxil edin");

        l2:
            string bStr = Console.ReadLine();

            bool state = int.TryParse(aStr, out int num);

            bool state2 = int.TryParse(bStr, out int num2);

            if (!state)
            {

                Console.WriteLine("A Ededi yeniden daxil edin");

                goto l1;


            }

            if (!state2)
            {
                Console.WriteLine("B Ededi yeniden daxil edin");

                goto l2;




            }

            else
            {
                if ((num % 10 == num2 % 10) && (num / 10 == num2 / 10))
                {



                    Console.WriteLine("Beli eynidir");



                }

                else
                {



                    Console.WriteLine("Xeyr eyni deyil");



                }





            }





        }

        static void Task5()
        {
            Console.WriteLine("Bir eded daxil edin");
        l1:
            string aStr = Console.ReadLine();

            bool state = int.TryParse(aStr, out int num);

            if (!state)
            {

                Console.WriteLine("Ededi yeniden daxil edin");

                goto l1;


            }


            else
            {

                int sum = 0;

                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                if (sum % 2 == 0)
                {

                    Console.WriteLine(sum);


                }
                else
                {

                    Console.WriteLine("ədəddə tək rəqəm mövcuddur");


                }




            }






        }


        static void Task6()
        {

            Student[] studentsArray = new Student[0];

            while (true)
            {
                Console.WriteLine("Press 'Enter' to add a new student, or any other key to display students and clear the screen.");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    // Add a new student
                    Student newStudent = GetStudentFromUser();
                    Array.Resize(ref studentsArray, studentsArray.Length + 1);
                    studentsArray[studentsArray.Length - 1] = newStudent;
                }
                else
                {
                    // Display students and clear the screen
                    Console.Clear();
                    DisplayStudents(studentsArray);
                }


            }

            static Student GetStudentFromUser()
            {
                Console.WriteLine("\nEnter student information:");

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Surname: ");
                string surname = Console.ReadLine();

                Console.Write("Birth Date (yyyy-MM-dd): ");
                DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);

                return new Student(id, name, surname, birthDate);
            }

            static void DisplayStudents(Student[] students)
            {
                Console.WriteLine("\nList of Students:");
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }
        }


        static void Task7()
        {

            DateTime tarix;

            while (true)
            {
                Console.Write("Tarixi daxil edin (dd.MM.yyyy): ");

                l1:
                string userInput = Console.ReadLine();

                if (DateTime.TryParseExact(userInput, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out tarix))
                {
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış tarix formatı. Yenidən cəhd edin.");
                    goto l1;

                }
            }

            string ayAdi = "";

            switch (tarix.Month)
            {
                case 1:
                    ayAdi = "yanvar";
                    break;
                case 2:
                    ayAdi = "fevral";
                    break;
                case 3:
                    ayAdi = "mart";
                    break;
                case 4:
                    ayAdi = "aprel";
                    break;
                case 5:
                    ayAdi = "may";
                    break;
                case 6:
                    ayAdi = "iyun";
                    break;
                case 7:
                    ayAdi = "iyul";
                    break;
                case 8:
                    ayAdi = "avqust";
                    break;
                case 9:
                    ayAdi = "sentyabr";
                    break;
                case 10:
                    ayAdi = "oktyabr";
                    break;
                case 11:
                    ayAdi = "noyabr";
                    break;
                case 12:
                    ayAdi = "dekabr";
                    break;
                default:
                    Console.WriteLine("Yanlış ay nömrəsi.");
                    return;
            }

            Console.WriteLine($"{tarix.ToString("dd.MM.yyyy")} - {tarix.Day} {ayAdi} {tarix.Year}-cü il");
        }
        }
    }


