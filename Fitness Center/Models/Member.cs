
﻿namespace Fitness_Center.Models
{
    public abstract class Member
    {
        public List <Member> Members;
        public int ID { get; set; }
        public string? Name { get; set; }

        public Member()
        {
            ID = 0;
            Name = "";
        }

        public Member(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public abstract void CheckIn(Member member, string input);

        public virtual void AddMember(Member member) => member.Members.Add(member);

        public virtual void RemoveMember(Member member) => member.Members.Remove(member);

        public abstract double CalculateFee();

    }


}
