
namespace Fitness_Center.Models
{
    public class SingleClubMember : Member
    {
        public Club Club {  get; set; }

        public SingleClubMember(int id, string name, Club club) : base(id, name)
        {
            ID = id;
            Name = name;
            Club = club;
        }

        public override void CheckIn(Member member)
        {
            throw new NotImplementedException();
        }

        public override void CalculateFee()

        {
            throw new NotImplementedException();
        }
    }
}
