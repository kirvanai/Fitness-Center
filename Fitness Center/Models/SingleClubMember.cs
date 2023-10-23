
namespace Fitness_Center.Models
{
    public class SingleClubMember : Member
    {
        public string ClubName { get; set; }

        public SingleClubMember()
        {

        }
        public SingleClubMember(string name, string clubName) : base(name)
        {
<<<<<<< HEAD
            ID = Member.Members == null ? 1000 : ID = 1000 + Members.Count;
=======
>>>>>>> 16501aab4817900c1c8064e9005c3c5a98f809a7
            Name = name;
            ClubName = clubName;
        }

        public override void CheckIn(Member member, string clubName)
        {

            SingleClubMember singleClubMember = new SingleClubMember();
            singleClubMember = (SingleClubMember)Member.Members.FirstOrDefault(n => n.Name == member.Name);

            if (clubName == singleClubMember.ClubName)
            {
                Console.WriteLine($"Thank you for checking into the {ClubName}");
            }
            else
            {
                Console.WriteLine("ERROR! Club not found under membership.");
            }
        }

        public override double CalculateFee()
<<<<<<< HEAD

=======
>>>>>>> 16501aab4817900c1c8064e9005c3c5a98f809a7
        {
            Club? club = new Club();

            club = Club.Clubs.FirstOrDefault(x => x.Name == ClubName);

            return club.Fee;
<<<<<<< HEAD
=======

>>>>>>> 16501aab4817900c1c8064e9005c3c5a98f809a7
        }
    }
}