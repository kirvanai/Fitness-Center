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
            ClubName = clubName;
        }

        public override void CheckIn(Member member, string clubName)
        {

            SingleClubMember singleClubMember = new SingleClubMember();
            singleClubMember = (SingleClubMember) member;

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
        {
            Club? club = new Club();

            club = Club.Clubs.FirstOrDefault(x => x.Name == ClubName);

            return club.Fee;
        }

    }

}