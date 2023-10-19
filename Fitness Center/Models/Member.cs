
﻿namespace Fitness_Center.Models
{
    public abstract class Member
    {
        public List <Member> members;
        public int ID { get; set; }
        public string? Name { get; set; }
        
        public Member(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public abstract void CheckIn(Member member);

        public virtual void AddMember(Member member) => member.members.Add(member);

        public virtual void RemoveMember(Member member) => member.members.Remove(member);

        public abstract void CalculateFee();

    }


}
