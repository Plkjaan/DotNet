using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //step 2: create Delegate Class according to the method
    public delegate void Del1(int invalidValue);

    class Program
    {
        static void Main()
        {

            try
            {
                Employee e1 = new Employee("Palak", 25336458, 2);

                Employee e2 = new Employee("Roshan", 9820);

                Employee e3 = new Employee("Roshan");

                Employee e4 = new Employee();

                Console.ReadLine();

            }
            catch (InvalidStringException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (InvalidSalaryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        //step 1 :Create a Method
        public static void InvalidMethod(int invalidValue)
        {

        }
    }


    public class Employee
    {

        //step 3 : Create a event of a delegate class
        public event Del1 delEvent;


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
                }
                else
                {
                    throw new InvalidStringException("Invalid String");
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
                if (value > 0)
                {
                    salary = value;
                }
                else 
                {
                    throw new InvalidSalaryException("Salary Cant be Below '0'");
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
                if (value > 0)
                {
                    departmentNo = value;
                    
                }
                else
                {
                    //step 4:raise the event here
                    if (delEvent != null)
                    {
                        delEvent(value);
                    }
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
            netSal = salary - (salary * 2) / 100;

            Console.WriteLine("Employess net salary is " + netSal);
            Console.WriteLine("");
            return netSal;
        }

        #endregion

        #region Constructor


        public Employee(string EmpName = "", decimal Salary = 0, short DepatementNo = 0)
        {
            empId = ++X;
            this.EmpName = EmpName;
            this.Salary = Salary;
            this.DepatementNo = DepatementNo;

            Console.WriteLine("Employee Id : " + EmpId);
            Console.WriteLine("Employee Name : " + EmpName);
            Console.WriteLine("Employee Salary : " + Salary);
            Console.WriteLine("Employee Department No : " + DepatementNo);
            Console.WriteLine();
        }

        #endregion


    }

    #region Exception Class

    [Serializable]
    internal class InvalidSalaryException : Exception
    {
        public InvalidSalaryException()
        {
        }

        public InvalidSalaryException(string message) : base(message)
        {
        }

    }

    [Serializable]
    internal class InvalidStringException : Exception
    {
        public InvalidStringException()
        {
        }

        public InvalidStringException(string message) : base(message)
        {
        }

    }
    #endregion
}

