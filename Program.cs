namespace Class_0410_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            Console.WriteLine(p.name);

            Person p1 = new Person("帶入後參數的名字");

            Console.WriteLine(p1.name);

            Student std= new Student();

            Console.WriteLine(std.name);

            Student std1 = new Student("主程式帶入參數的名字");

            Console.WriteLine(std1.name);
        }
    }



   public class Person
   {
        public string name;

        public Person()
        {
            name = "Person的名字";
        }
        public Person(string name)
        {
            this.name= name;
        }
   }


   public class Student : Person 
   {
        static string name="Std靜態資料型別預設字";

        public Student():base(name)
        {

        }
        public Student(string name) : base(name)
        {

        }
    }





}
