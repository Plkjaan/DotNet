using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main()
        {
            //Employee e1 = new Employee();
            //e1.EmpId = 1 ;
            //e1.EmpName = "Palak";
            //e1.DepatementNo = 1;
            //e1.Salary = 160000;
            //e1.GEtNetSalary();



            Employee e1 = new Employee( "Roshan", 160632,2);
           // e1.GEtNetSalary();
            Console.WriteLine(e1.EmpId);
            Employee e2 = new Employee( "Roshan", 9820);
           // e2.GEtNetSalary();
            Console.WriteLine(e2.EmpId);
            Employee e3 = new Employee( "Roshan");
           // e3.GEtNetSalary();
            Console.WriteLine(e3.EmpId);
            Employee e4 = new Employee();

       //     Console.WriteLine("Employee Id: " + e1.EmpId + " Employee Name : " + e1.EmpName + " Department No : " + e1.DepatementNo + " Salary : " + e1.Salary + " ");
            Console.WriteLine("Employee Id1: " + e1.EmpId + " Employee 2 : " + e2.EmpId + " emp3 : " + e3.EmpId + " e4 : " + e4.EmpId + " ");
            Console.ReadLine();
        }
    }


    public class Employee
    {
        #region Properties
        //variables
        public static int X;
        private int empId;

    //Properties
        public int EmpId
        { 
            get
            {
                
                return empId; //returns variable
            }
        }
        public String empName;

        public String EmpName
        {
            set
            {
                if (value != "")
                {
                    empName = value;
                    //Console.WriteLine("Employee Name " + empName);
                   // Console.WriteLine("");
                }   
                else
                {
                    Console.WriteLine("Enter Employee Name");
                    Console.WriteLine("");
                }
            }
            get
            {
                return empName;
            }
        }

        public decimal salary;

        public decimal Salary
        {
            set
            {
                if(value >0 && value <1000)
                {
                    salary = value;
                    Console.WriteLine("Employee is Earning poor");
                    //Console.WriteLine("");
                }
                else if(value > 1000 && value < 10000)
                {
                    salary = value;
                    Console.WriteLine("Employee is Below Average");
                    //Console.WriteLine("");
                }
                else if(value > 10000)
                {
                    salary = value;
                    Console.WriteLine("Employee is Earning good");
                    //Console.WriteLine("");
                }
            }
            get
            {
                return salary;      //return Variable
            }
        }

        public short departmentNo;
    
        public short DepatementNo
        {
            set
            {
                if(value > 0)
                {
                    departmentNo = value;
                   // Console.WriteLine("Depatement No is "+departmentNo);
                    //Console.WriteLine("Depatement No is Valid!!!");
                    //Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Deapatemnet no is InValid!!!");
                    //Console.WriteLine("");
                }
            }
            get
            {
                return departmentNo;  //return Variable
            }
        }

        #endregion

        #region GetNetSalary Method

        decimal netSal;

        public decimal GEtNetSalary()
        {
            netSal = salary-(salary*2)/100;

            Console.WriteLine("Employess net salary is "+netSal);
            Console.WriteLine("");
            return netSal;
        }

        #endregion

        #region Constructor
        
       
        public Employee( string EmpName = "", decimal Salary = 0, short DepatementNo = 0)
        {
            empId = ++X;
            this.EmpName = EmpName;
            this.Salary = Salary;
            this.DepatementNo = DepatementNo;

            Console.WriteLine("Employee Id : "+EmpId);
            Console.WriteLine("Employee Name : " + EmpName);
            Console.WriteLine("Employee Salary : " + Salary);
            Console.WriteLine("Employee Department No : " + DepatementNo);

            //Console.WriteLine("");


        }

        #endregion

        
    }

}
