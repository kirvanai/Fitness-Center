namespace Fitness_Center.Models
{
    public class Data
    {
        public void DataSetup()
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
            List<Facilities> fac4 = new List<Facilities>() { Facilities.treadmill, Facilities.freeweights, Facilities.machines, Facilities.cardiomachines };
            Club club4 = new Club(4, "Club D", ar4, fac4, 40);

            Club.Clubs.Add(club1);
            Club.Clubs.Add(club2);
            Club.Clubs.Add(club3);
            Club.Clubs.Add(club4);

            SingleClubMember mem1 = new SingleClubMember("John Adams", club1.Name);
            SingleClubMember mem2 = new SingleClubMember("George Washinton", club2.Name);
            SingleClubMember mem3 = new SingleClubMember("Abe Lincoln", club3.Name);


            MultiClubMember mem4 = new MultiClubMember("John Hancock");
            MultiClubMember mem5 = new MultiClubMember("Thomas Edison");
            MultiClubMember mem6 = new MultiClubMember("Bill Clinton");

            Member.Members.Add(mem1);
            Member.Members.Add(mem2);
            Member.Members.Add(mem3);
            Member.Members.Add(mem4);
            Member.Members.Add(mem5);
            Member.Members.Add(mem6);
        }

    }
}
