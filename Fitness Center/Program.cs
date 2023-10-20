using Fitness_Center.Models;

namespace Fitness_Center
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] ar1 = new string[] { "1 Fake St", "Springfield, MI, 45969" };
            List<Facilities> fac1 = new List<Facilities>() { Facilities.treadmill };
            Club club1 = new Club(1, "Club A", ar1, fac1, 10);

            
            SingleClubMember mem1 = new SingleClubMember(1001,   "John Adams", club1);
            mem1.CheckIn(mem1, "Club A");

        }
    }
}

