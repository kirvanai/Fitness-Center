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
        public static List<Club> Clubs { get; set; } = new List<Club>();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; } 
        public string State { get; set; }
        public int ZipCode { get; set; }
        public List<Facilities> ClubFacilities { get; set; }
        public double Fee { get; set; }


        public Club()
        {

        }

        public Club(int id, string name, string address, string city, string state, int zipCode, List<Facilities> clubFacilities, double fee)
        {
            Id = id;
            Name = name;
            Address = address;
            State = state;
            City = city;
            ZipCode = zipCode;

            ClubFacilities = clubFacilities;
            Fee = fee;

        }
        
    }

}