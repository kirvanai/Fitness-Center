
﻿namespace Fitness_Center.Models
{
    public class MultiClubMember : Member
    {
        public int PointsEarned { get; set; }

        public List<Club> clubs { get; set; }

        public MultiClubMember(int id, string name) : base(id, name)
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
