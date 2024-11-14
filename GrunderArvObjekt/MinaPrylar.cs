using System.ComponentModel;

namespace GrunderArvObjekt
{
    public static class MinaPrylar
    {

        //Första objektet en familjemedlemm
        public class Person
        {
            public string Name { get; set; }
            public string Origin { get; set; }
            public int Age { get; set; }
            public double Heigth { get; set; }
            public string NickName { get; set; }


            //Klassens konstruktuor
            public Person(string name, string origin, int age, double height, string nickName)
            {
                Name = name;
                Origin = origin;
                Age = age;
                Heigth = height;
                NickName = nickName;

            }
        }
        
            //Metod som ska skapa en person och skriva ut den i konsolen
            public static void MakePerson()
            {
            //Skapar själva personen
            //Eftersom att det fanns en konstruktor behöver du inte skriva in vad varje egenskap betyder utan du kan skriva in det i parentesen som nedan
            Person person = new Person("Nirar", "Assyr", 35, 1.85, "Nero");



            //Skriv ut den nya personen du skapat
            Console.WriteLine("-------MIN PERSON--------");
            Console.WriteLine("Namn: " + person.Name);
            Console.WriteLine("Rötter: " + person.Origin);
            Console.WriteLine("Ålder: " + person.Age);
            Console.WriteLine("Längd: " + person.Heigth);
            Console.WriteLine("Smeknamn: " + person.NickName);
            Console.WriteLine("-------------------------");
            }
        














        //Andra objektet är ett husdjur. Detta objekt ska det finnas flera av
        public class Dog
        {
            public string Race { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string NickName { get; set; }
            public string Colour { get; set; }



            //Klassens konstruktor
            public Dog(string race, string name, int age, string nickName, string colour)
            {
                Race = race;
                Name = name;
                Age = age;
                NickName = nickName;
                Colour = colour;
            }
        }

        //Skapa en metod för att skapa och skriva ut ditt husdjur
        //Du ska ha bestämt hundens egenskaper
        public static void MakeDogs()
        {
            //Skapa först en lista med hundar.
            //Annars skulle du kunna skapa en tom lista och lägga till hundar med Add. metoden
            List<Dog> dogs = new List<Dog>
            {
                new Dog("Labrador", "Luffsen", 13, "Luffe", "brun"),
                new Dog("Dalmatin", "Dalmatino", 4, "Tino", "svart och vit"),
                new Dog("Amstaff", "Stefan", 7, "Devil", "svart")
            };

            //Skriv ut listan vilket kan göras via en if sats eller foreach.
            //Foreach används ofta med lists, speciellt när ingenting ska göras med utskiften. Tex hitta index osv.
            foreach(Dog dog in dogs)
            {
                Console.WriteLine("-------MIN HUND--------");
                Console.WriteLine("Ras: " + dog.Race);
                Console.WriteLine("Namn: " + dog.Name);
                Console.WriteLine("Ålder: " + dog.Age);
                Console.WriteLine("Färg: " + dog.Colour);
                Console.WriteLine("-----------------------");
            }

        }











        //Tredje objektet är en väska
        public class Bag
        {
            //Propertys
            public string Brand { get; set; }
            public string Colour { get; set; }
            public int Age { get; set; }
            public string Form { get; set; }
            public int Price { get; set; }


            //Klassens konstruktor
            public Bag(string brand, string colour, int age, string form, int price)
            {
                Brand = brand;
                Colour = colour;
                Age = age;
                Form = form;
                Price = price;
            }

        }

        //Metod för att skapa och skriva ut väska.
        //Denna gång ska användaren bestämma vilka egenskaperna ska vara
        public static void MakeBag()
        {
            //Ta först emot alla värden för propertys från användaren (HÅRDKOKTA SÄTTET)
            Console.WriteLine("Du behöver skriva in egenskaperna på din väska. Besvara följande frågor:");
           
            Console.Write("1. Vilket märke ska väskan vara?: ");
            string brand = Console.ReadLine();

            Console.Write("2. Vilken färg ska väskan vara?: ");
            string colour = Console.ReadLine();

            Console.Write("3. Hur gammal ska väskan vara (i år)?: ");
            int age; //Detta måste finnas med så att när vi gör en ny insats av Bag klassen ska den kunna ta in int age variabeln
                     //Om vi inte hade skrivit int age; hade det inte gått att mata in det i Bag insatsens parentes som age
            while (!int.TryParse(Console.ReadLine(), out age)) //Egentligen ska det stå out INT age men vi har redan deklarerat age en rad ovan därför räcker out age
            {
                Console.WriteLine("Ogiltig inmatning. Skriv hur gammal väskan ska vara med ett heltal (i år)");
            }
            // Varför while?Om vi skulle använda en if-sats här, skulle den bara kontrollera inmatningen en gång.
            // Om användaren skriver in något ogiltigt (t.ex. en textsträng som "hej" istället för ett tal),
            // skulle if bara märka felet en gång och sedan gå vidare med ogiltigt värde eller orsaka ett fel senare i koden.

            Console.Write("4. Viken form ska väskan ha?: ");
            string form = Console.ReadLine();

            Console.Write("5. Vilket pris ska väskan ha?: ");
            int price;
            while(!int.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Ogiltig inmatning. Skriv hur mycket väskan ska kosta i heltal.");
            }

            Console.WriteLine("Tryck enter för att generara din väska ...");
            Console.ReadKey();
            Console.Clear();


            //Skapa en ny insats av Bag klassen med användarens input
            Bag bag = new Bag(brand, colour, age,  form,  price);


            //Skriv nu ut väskan i konsolen.
            Console.WriteLine("-------MIN VÄSKA--------");
            Console.WriteLine("Märke: " + bag.Brand);
            Console.WriteLine("Färg: " + bag.Colour);
            Console.WriteLine("Ålder: " + bag.Age);
            Console.WriteLine("Form: " + bag.Form);
            Console.WriteLine("Pris: " + bag.Price);
            Console.WriteLine("------------------------");

        }




    }
}
