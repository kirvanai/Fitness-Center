using Fitness_Center.Models;
using Newtonsoft.Json;

namespace Fitness_Center.Data
{
    public class ClubData
    {
        public void DataSetup()
        {
            var outPutDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var iconPath = Path.Combine(outPutDirectory, @"Clubs.txt");

            string jsonString = File.ReadAllText(iconPath);

            Club.Clubs = JsonConvert.DeserializeObject<List<Club>>(jsonString);

            iconPath = Path.Combine(outPutDirectory, @"SingleMembers.txt");

            jsonString = File.ReadAllText(iconPath);

            Member.Members = JsonConvert.DeserializeObject<List<Member>>(jsonString);

            //foreach (SingleClubMember singleMember in singleMembers)
            //{
            //    Member.Members.Add(singleMember);
            //}

            iconPath = Path.Combine(outPutDirectory, @"MultiMembers.txt");

            jsonString = File.ReadAllText(iconPath);

            List<MultiClubMember> multiMembers = JsonConvert.DeserializeObject<List<MultiClubMember>>(jsonString);

            foreach (MultiClubMember multiMember in multiMembers)
            {
                Member.Members.Add(multiMember);
            }
        }
    }
}
