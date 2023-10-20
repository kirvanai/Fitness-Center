
﻿namespace Fitness_Center.Models
{
    public class MultiClubMember : Member
    {
        public int PointsEarned { get; set; }

        public List<Club> Clubs { get; set; }

        public MultiClubMember(int id, string name, List<Club> clubs) : base(id, name)
        {
            ID = id;
            Name = name;
            Clubs = clubs;

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
