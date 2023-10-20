using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Center.Models
{
    public enum Facilities
    {
        treadmill,
        freeweights,
        machines,
        cardiomachines,
        indoortrack,
        tenniscourt,
        basketballcourt,
        climbingwall,
        yogastudio,
        lockerroom,
        swimmingpool,
        steamroom
    }

    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string[] Address { get; set; }
        public List<Facilities> ClubFacilities { get; set; }
        public double Fee { get; set; }

        public Club(int id, string name, string[] address, List<Facilities> clubFacilities, double fee)
        {
            Id = id;
            Name = name;
            Address = address;
            ClubFacilities = clubFacilities;
            Fee = fee;

        }

        public List<Club> Clubs { get; set; } = new List<Club>();
        


    }

}

