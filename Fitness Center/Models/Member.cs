
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
<<<<<<< HEAD
            ID = 1000 + Members.Count;
=======
            ID = Members.Count == 0 ? 1000 : Members.Max(m => m.ID) + 1;
>>>>>>> 16501aab4817900c1c8064e9005c3c5a98f809a7
            Name = name;
        }

        public abstract void CheckIn(Member member, string clubName);

        public virtual void AddMember(Member member) => Member.Members.Add(member);

        public virtual void RemoveMember(Member member) => Member.Members.Remove(member);

        public abstract double CalculateFee();

    }


}
