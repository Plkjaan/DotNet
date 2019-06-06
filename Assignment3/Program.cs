using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        //Array[]
        static void Main1()
        {

           

            Student [] s= new Student[2];
           

            for(int i=0; i<s.Length; i++)
            {
                s[i] = new Student();
                Console.WriteLine("Enter Student Details :: ");
                Console.WriteLine();
                Console.WriteLine("Enter Student Roll No : ");
                s[i].RollNo=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name : ");
                s[i].Name=Console.ReadLine();
                Console.WriteLine("Enter Marks In Subject1 : ");
                s[i].Subject1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Marks In Subject2 : ");
                s[i].Subject2 = Convert.ToDecimal(Console.ReadLine());
                
            }

            foreach(Student b in s)
            {
                b.Display();
            }
             Console.ReadLine(  );
            
        }

        //List<Student>
        static void Main2()
        {
            #region List<Student>

            List<Student> stud = new List<Student>();
            stud.Add(new Student { RollNo = 1, Name = "Roshan", Subject1 = 80, Subject2 = 75 });
            stud.Add(new Student { RollNo = 2, Name = "Palak", Subject1 = 70, Subject2 = 67 });
            stud.Add(new Student { RollNo = 3, Name = "Piyu", Subject1 = 85, Subject2 = 56 });
            stud.Add(new Student { RollNo = 4, Name = "Shlok", Subject1 = 84, Subject2 = 73 });
            stud.Add(new Student { RollNo = 5, Name = "Pratiksha", Subject1 = 60, Subject2 = 59 });

            Console.WriteLine();
            foreach (Student aStudent in stud)
            {

                Console.WriteLine("RollNo : " + aStudent.RollNo);
                Console.WriteLine("Name : " + aStudent.Name);
                Console.WriteLine("Subject1 : " + aStudent.Subject1);
                Console.WriteLine("Subject1 : " + aStudent.Subject2);
                aStudent.GetPercentage();
                Console.WriteLine();
            }

            //s.Remove(new Student { RollNo = 5, Name = "Pratiksha", Subject1 = 60, Subject2 = 59 });

            foreach (Student aStudent in stud)
            {

                aStudent.Display();

                //Console.WriteLine("RollNo : " + aStudent.RollNo);
                //Console.WriteLine("Name : " + aStudent.Name);
                //Console.WriteLine("Subject1 : " + aStudent.Subject1);
                //Console.WriteLine("Subject1 : " + aStudent.Subject2);
                //aStudent.GetPercentage();
                Console.WriteLine();
            }

            #endregion

            Console.ReadLine();
        }

        //Students Class Extens List<Student> 
        static void Main()
        {
            #region Students List<Student>

            Students stud = new Students();
            stud.Add(new Student { RollNo = 1, Name = "Roshan", Subject1 = 80, Subject2 = 75 });
            stud.Add(new Student { RollNo = 2, Name = "Palak", Subject1 = 70, Subject2 = 67 });
            stud.Add(new Student { RollNo = 3, Name = "Piyu", Subject1 = 85, Subject2 = 56 });
            stud.Add(new Student { RollNo = 4, Name = "Shlok", Subject1 = 84, Subject2 = 73 });
            stud.Add(new Student { RollNo = 5, Name = "Pratiksha", Subject1 = 60, Subject2 = 59 });

            Console.WriteLine();

            foreach (Student aStudent in stud)
            {
                aStudent.Display();
                Console.WriteLine();
            }

            stud.RemoveAt(4);

            foreach (Student aStudent in stud)
            {

                aStudent.Display();
                Console.WriteLine();
            }

            #endregion

            Console.ReadLine();
        }

    }

    public class Student 
    {
        //Variable
        public int rollNo;
        public string name;
        public decimal subject1;
        public decimal subject2;
        #region Property
        public int RollNo
        {
            set
            {
                if(value > 0)
                {
                    rollNo = value;
                }
                else
                {
                    throw new Exception("Invalid Rollno") ;
                }
            }
            get
            {
                return rollNo;
            }
        }
        public string Name
        {
            set
            {
                if(value != "")
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Invalid Name");
                }
            }
            get
            {
                return name;
            }
        }
        public decimal Subject1
        {
            set
            {
                if(value > 1 && value < 100)
                {
                    subject1 = value;
                }
                else
                {
                    throw new Exception("Invalid Marks");
                }
            }
            get
            {
                return subject1;
            }
        }
        public decimal Subject2
        {
            set
            {
                if(value > 1 && value < 100)
                {
                    subject2 = value;
                }
                else
                {
                    throw new Exception("Invalid Marks");
                }
            }
            get
            {
                return subject2;
            }
        }
        #endregion


        #region GetPercentage

        public decimal percentage;
        public decimal GetPercentage()
        {
            percentage = (subject1 + subject2)*100 / 200;

            //Console.WriteLine("Persentage : "+percentage);
            return percentage;
        }

        #endregion

        //#region Constructor

        //public Student(int RollNo, string Name, decimal Subject1, decimal Subject2)
        //{
        //    this.RollNo = RollNo;
        //    this.Name = Name;
        //    this.Subject1 = Subject1;
        //    this.Subject2 = Subject2;

        //}

        //#endregion

        #region DisplayMethod

        public void Display()
        {
            Console.WriteLine("Student Roll No :- "+RollNo);
            Console.WriteLine("Student Name :- " + Name);
            Console.WriteLine("Subject1 :- " + Subject1);
            Console.WriteLine("Subject1 :- " + Subject2);
            Console.WriteLine("Persentage :- "+GetPercentage());

        }
        #endregion
    }
    public class Students :List<Student>
    {

    }
}
