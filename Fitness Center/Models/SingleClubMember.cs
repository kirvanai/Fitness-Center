
namespace Fitness_Center.Models
{
    public class SingleClubMember : Member
    {
        public Club club {  get; set; }

        public SingleClubMember(int id, string name) : base(id, name)
        {
            ID = id;
            Name = name;

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
