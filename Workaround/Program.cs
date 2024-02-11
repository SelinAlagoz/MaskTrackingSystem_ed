using BusinessRule.Abstract;
using BusinessRule.Concrete;
using Entities.Concrete;


namespace Workaround
{

    class Program
    {
        static void Main(string[] args)
        {
           // variables();
           Citizen citizen = new Citizen(); 
           citizen.Name = "Test";
           

            //Console.ReadLine();

            sayHi();
            sayHi(name: "Selin");

            int result = Summitt(3,7);

            //Arrays
            string student1 = "Engin";
            string student2 = "Kerem";
            string student3 = "Berkay";

            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Keram";
            students[2] = "Berkay";
            students = new string[4]; //If we do this, we keep a new address in the stack heap and our other values ​​are gone.Then first address goes with garbage collector :(
            // so we call these "referance type " which are arrays, classes, interfaces, abstracts.
            // double, int , float are variable types also. All of them in stack.
            students[3] = "Selin";

            for (int i = 0; i< students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            string[] cities1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] cities2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            cities2 = cities1;
            cities1[0] = "Adana";
            Console.WriteLine(cities1[0]);

            foreach (string city in cities1) //We are returning structures in array format. We use this structure instead of using the long for structure.
            {
                Console.WriteLine(city);
            }
            //Mylist***** listeyi bilmiyor olsaydık nasıl yazardık.
            List<string> newCities = new List<string> { "Ankara", "İstanbul", "İzmir" }; //list is an class.
            newCities.Add("Kayseri");
            foreach(var cityy in newCities)
            {
                Console.WriteLine(cityy); 
            }

            Console.WriteLine(student1);
            Console.WriteLine(student2);

            PttManager pttManager = new PttManager(new CitizenManager());
            pttManager.GiveMask(citizen);
            
        }

        static void sayHi(string name = "anonymous")
        {
            Console.WriteLine("Hi !" + name);
        }

        static int Summitt(int number1, int number2)
        {
            int result = number1 + number2;
            Console.Out.WriteLine("Sum :" + result);
            return result;
        }
        private static void variables()
        {
            string message = "Merhaba";
            double price = 10000;
            int number = 100;
            bool isLogIn = false;

            string name = "Selin";
            string surname = "Alagoz";
            int birthYear = 1997;
            long tcNo = 123449;

            Console.WriteLine(price * 1.18);
        }
    }


}