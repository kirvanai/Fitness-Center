namespace Fitness_Center.Models
{
    

    public class Club
    {
        public static List<Club> Clubs { get; set; } = new List<Club>();

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; } 
        public string? State { get; set; }
        public int ZipCode { get; set; }
        public double Fee { get; set; }


        public Club()
        {

        }

        public Club(int id, string name, string address, string city, string state, int zipCode, double fee)
        {
            Id = id;
            Name = name;
            Address = address;
            State = state;
            City = city;
            ZipCode = zipCode;
            Fee = fee;

        }
        
    }

}