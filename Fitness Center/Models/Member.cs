
﻿namespace Fitness_Center.Models
{
    public abstract class Member
    {
        public static List <Member> Members= new List <Member> ();
        public int ID { get; set; }
        
        public string? Name { get; set; }

        public Member()
        {
            ID = 0;
            Name = "";
        }

        public Member(string name)
        {
            ID = Members.Count == 0 ? 1000 : Members.Max(m => m.ID) + 1;
            Name = name;
        }

        public abstract void CheckIn(Member member, string clubName);

        public virtual void AddMember(Member member) => Member.Members.Add(member);

        public virtual void RemoveMember(Member member) => Member.Members.Remove(member);

        public abstract double CalculateFee();

    }


}
