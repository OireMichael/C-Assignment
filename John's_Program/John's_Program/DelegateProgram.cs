namespace John_s_Program
{
    //********************** OIRE MICHAEL SEM2 PCSE. C# TEST ASSIGNMENT 2************

    using System.Collections;
    using System.Collections.Generic;

    public delegate void StudentDetails(String str); // Delegate
    internal class DelegateProgram

    {
       
        public String Name;
        public int Id;  
        public String Address;

        //*******************Solution 2***************
        public String StudentAddress
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        static void Main(string[] args)
        {
            //*************number 1******************
            StudentDetails objstdname = new StudentDetails(getStudentName);
            StudentDetails objstdId = new StudentDetails(studentId);
            Console.WriteLine("\t\t QUESTION 1 \n");
            objstdname("OIRE MICHAEL");
            objstdId("UBB40/05/021" + "\n");

            //************number 2*******************
            Console.WriteLine("\t\t QUESTION 2 \n");

            DelegateProgram objaddress = new DelegateProgram();
            objaddress.StudentAddress = "Soroti City East, Otatai Ward Owollo Village";
            Console.WriteLine("The student Address is: " + objaddress.StudentAddress+"\n");

            //************number 3*******************
            //*******************Solution 3***************
            Console.WriteLine("\t\t QUESTION 3 \n");

            List<DelegateProgram> students = new List<DelegateProgram>()
            {
                new DelegateProgram{Id = 341, Name = "Oire Mike",Address = "Soroti"},
                new DelegateProgram{Id = 342, Name = "Eletu Elvis",Address = "Kampala"},
                new DelegateProgram{Id = 343, Name = "Eumu Emmanuel",Address = "Iganga"},
                new DelegateProgram{Id = 344, Name = "Epinyu Daniel",Address = "Kamuli"}

            };
            foreach (var DelegateProgram in students)
            {
             Console.WriteLine(DelegateProgram.Id +", "+ DelegateProgram.Name+ ", " + DelegateProgram.Address);
            }
            Console.ReadLine();
        }
        //*******************Solution 1***************
        static void getStudentName(String name)
        {
            Console.WriteLine("The name is " + name);
        }
        static void studentId(String id)
        {
            Console.WriteLine("The Id is " + id);
        }
    }
}