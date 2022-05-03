using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero_Object
{
    internal class District
    {
        public string Title { get; set; }
        public string City { get; set; }
        public int DistrictID { get; set; } 

        //public int DistrictId
        //{
        //    get { return _districtId; }
        //    set {
        //        if (value < 0)
        //            throw new ArgumentOutOfRangeException(nameof(value));
        //        _districtId = value; 
        //    }
        //}

        //public void SetDistrictId(int districtId)
        //{
        //    if (districtId <= 0)
        //        throw new ArgumentOutOfRangeException(nameof(districtId));
        //    _districtId = districtId;
        //}

        //public int GetDistrictId()
        //{
        //    return DistrictID;
        //}

        public List<Hero> HeroesInTheDistrict { get; set; }

        public District()
        {
            Title = "No title";
            City = "My city";
            DistrictID = 0;
            HeroesInTheDistrict = new List<Hero>();

        }
        public District(string title, string city, int districtID, List<Hero> heroesInTheDistrict)
        {
            Title=title;
            City=city;  
            DistrictID=districtID;
            HeroesInTheDistrict=heroesInTheDistrict;
        }

        public override string ToString()
        {
            var text = $"{Title}, {City}, {DistrictID}";
            return text; 
        }
        public bool Add(Hero hero)
        {
            HeroesInTheDistrict.Add(hero);
            return true;
        }
       /* public List<Hero> Remove (int index)
        {
            HeroesInTheDistrict.RemoveAt(index);
        }*/
    }
}






/*
Hero defaultHero = new Hero();
Hero netMan = new Hero("Valera", "Dik", ".NetMan", 1, HeroType.Hero, 21);
Hero sonic = new Hero("Kent", "Clark", "Sonic", 2, HeroType.Hero, 46);
List<Hero> metropole = new List<Hero>();
metropole.Add(defaultHero);
metropole.Add(netMan);
metropole.Add(sonic);
*/