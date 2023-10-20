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

            string[] ar2 = new string[] { "2 Fake St", "Springfield, MI, 45969" };
            List<Facilities> fac2 = new List<Facilities>() { Facilities.treadmill, Facilities.freeweights, };
            Club club2 = new Club(2, "Club B", ar2, fac2, 20);


            string[] ar3 = new string[] { "3 Fake St", "Springfield, MI, 45969" };
            List<Facilities> fac3 = new List<Facilities>() { Facilities.treadmill, Facilities.freeweights, Facilities.machines };
            Club club3 = new Club(3, "Club C", ar3, fac3, 30);

            string[] ar4 = new string[] { "4 Fake St", "Springfield, MI, 45969" };
            List<Facilities> fac4 = new List<Facilities>() { Facilities.treadmill, Facilities.freeweights,Facilities.machines, Facilities.cardiomachines };
            Club club4 = new Club(4, "Club D", ar4, fac4, 40);

            club1.Clubs.Add(club1);
            club2.Clubs.Add(club2);
            club3.Clubs.Add(club3);
            club4.Clubs.Add(club4);

            SingleClubMember mem1 = new SingleClubMember(1001, "John Adams", club1);
            SingleClubMember mem2 = new SingleClubMember(1002, "George Washinton", club2);
            SingleClubMember mem3 = new SingleClubMember(1003, "Abe Lincoln", club3);

            List<Club> mclubs1 = new List<Club>() { club1, club2};
            List<Club> mclubs2 = new List<Club>() { club1, club3};
            List<Club> mclubs3 = new List<Club>() { club1, club4};


            MultiClubMember mem4 = new MultiClubMember(1004, "John Hancock", mclubs1 );
            MultiClubMember mem5 = new MultiClubMember(1005, "Thomas Edison", mclubs2);
            MultiClubMember mem6 = new MultiClubMember(1006, "Bill Clinton", mclubs3);



        }
    }
}

