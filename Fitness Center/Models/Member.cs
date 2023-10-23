
﻿namespace Fitness_Center.Models
{
    public abstract class Member
    {
        public static List <Member> Members;
        public int ID { get; set; }

        public string? Name { get; set; }

        public Member()
        {
            ID = 0;
            Name = "";
        }

        public Member(string name)
        {
            ID = 1000+ Members.Count;
            Name = name;
        }

        public abstract void CheckIn(Member member, string input);

        public virtual void AddMember(Member member) => Member.Members.Add(member);

        public virtual void RemoveMember(Member member) => Member.Members.Remove(member);

        public abstract double CalculateFee();

    }


}
