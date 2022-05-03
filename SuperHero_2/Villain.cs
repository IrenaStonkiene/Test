using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_2
{
    internal class Villain : Person
    {
        public Villain() : base("John", "Putin")

        public int Age { get; set; }

        public string Nickname { get; set; }

        public int VillainId { get; set; }

        public int CrimeTime { get; set; }

        public List<string> VillainPowerList { get; set; }

        public Villain()
        {
            Name = "Berry";
            Surname = "Tree";
            Nickname = "Villain";
            VillainId = 0;
            CrimeTime = 0;
            VillainPowerList = new List<string>();
            Age = 18;
        }

        public Villain(string nickname, int villainId, int deedTime, List<string> villainPowerList, int age : base(name, surname)
        {
            Name = name;
            Surname = surname;
            Nickname = nickname;
            VillainId = villainId;
            CrimeTime = crimeTime;
            VillainPowerList = villainPowerList;
            Age = age;
        }

        Villain cat = new Villain("John", "Putin", "Cat", 1, 21, 20);
        Villain shark = new Villain("Kent", "Smith", "Shark", 2, 46, 24);
        
        List<Villain> metropole = new List<Villain>();
            metropole.Add(cat);
            metropole.Add(shark);


        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\n Surname: {Surname}" +
                $"\n Nickname: {Nickname}\n VillainID: {VillainId} " +
                $"\n Crimetime: {CrimeTime}" +
                $"\n Age: {Age}");
        }

        public int CalculateLevel()
        {
            int level = 0;
            if (CrimeTime < 20)
            {
                level = 1;
            }
            if (CrimeTime >= 20 && CrimeTime <= 40)
            {
                level = 2;
            }
            if (CrimeTime > 40)
            {
                level = 3;
            }

            return level;
        }
    }
}
