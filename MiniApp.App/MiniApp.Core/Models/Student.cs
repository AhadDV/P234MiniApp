

namespace MiniApp.Core.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void GetFullInfo()
        {
            Console.WriteLine(Name+" "+Email);
        }
    }
}
