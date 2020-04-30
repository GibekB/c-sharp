using System;
using System.Collections.Generic;

namespace SuperHeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person NPC1 = new Person("Joe", "NPC1");
            Person NPC2 = new Person("Karen", "NPC2");
            Person NPC3 = new Person("Manager", "NPC3");

            Superhero Hero1 = new Superhero("Good Joe", null, "Gun","OG Joe", "RobinHood Criminals");
            Superhero Hero2 = new Superhero("Bad Joe",null, "Crowbar","Gangster Joe", "RobinHood Criminals");
            Superhero Hero3 = new Superhero("Demonic Joe",null,"Cross","Lucifer Joe","Stupid Partners");

            Villain Badguy1 = new Villain("Grandma Karen",null,"Overfeeding","RobinHood Criminals","Karen Incorporated");
            Villain Badguy2 = new Villain("Sexy Karen", null, "MindControl", "RobinHood Criminals","Karen Incorporated");
            Villain Badguy3 = new Villain("Holy Karen", null, "Bible", "Sexy Karen", "Stupid Partners");

            List<Person> Idiots = new List<Person>
            {
                NPC1, NPC2, NPC3, Hero1, Hero2, Hero3, Badguy1, Badguy2, Badguy3
            };
            foreach (var idiot in Idiots)
            {
                Console.WriteLine(idiot.PrintGreeting());
            }
            Console.ReadLine();
        }
    }




    class Person
    {
        public string Name { get; set; }
        public string Nickname { get; set; }
        
        public Person(string name, string nickname)
        {
            Name = name;
            Nickname = nickname;
        }
        public override string ToString()
        {
            return Nickname;
        }

        public virtual string PrintGreeting()
        {
            return $"Hi, my name is {Name}, you can call me {Nickname}.";
        }
    }

    class Superhero : Person
    {
        public string Superpower { get; set; }
        public string Realname { get; set; }
        public string Team { get; set; }
        public Superhero(string name, string nickname, string superpower, string realname, string team) : base(name, nickname)
        {
            Superpower = superpower;
            Realname = realname;
            Name = name;
            Nickname = null;
            Team = team;
        }

        public override string PrintGreeting()
        {
            return $"Howdy, my name is {Name}, you can call me {Realname} my superpower is {Superpower}, I am in team {Team}";
        }
    }

    class Villain : Person
    {
        public string Evilpower { get; set; }
        public string Nemesis { get; set; }
        public string Team { get; set; }
        public Villain(string name, string nickname, string evilpower, string nemesis, string team) : base(name, nickname)
        {
            Evilpower = evilpower;
            Name = name;
            Nickname = null;
            Nemesis = nemesis;
            Team = team; 
            
        }
        public override string PrintGreeting()
        {
            return $"Hia, my name is {Name}, i hate {Nemesis}, i can do {Evilpower} I'm with {Team}";
        }
    }
}
