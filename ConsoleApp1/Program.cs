// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

namespace AboutPeople
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Teacher teacher = new Teacher("Aziza","Suleymanova",27);
            Student student = new Student("Abdullah","Manafli",16);
            teacher.Explain();
            student.Learn();
            
            
            
            
        }



    }




    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            

        }
        
    }

    public class Teacher : Person
    {

        public  Teacher(string name, string surname,int age) : base(name, surname, age)
        {
           

        }

        public void Explain()
        {
            Console.WriteLine("Explaing...");
        }
    }
      
       public class Student : Teacher
    {     
         public Student(string name, string surname,int age) : base (name, surname, age)
        {

        }
         public void Learn()
        {
            Console.WriteLine("Learning...");
        }
    }

}









