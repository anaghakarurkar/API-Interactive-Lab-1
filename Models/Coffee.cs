
namespace API_Interactive_Lab_1.Models
{
    public class Coffee
    {
        public string Name { get; private set; }
        public int ID { get; private set; }
    

        public Coffee(string? name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Name = "latte";
                ID = -1;
            }
            else
            {
                Name = name;
                ID = 7;
            }
        }
    }
}
