using MiniApp.App.Servcies;
StudentService StudentService = new StudentService();

Console.WriteLine("0.Close App");
Console.WriteLine("1.Show Students");
Console.WriteLine("2.Create Student");

string RequestNumber = Console.ReadLine();

while (RequestNumber != "0")
{
    switch (RequestNumber)
    {
        case "1":
            StudentService.ShowStudents();
            break;
        case "2":
            StudentService.CreateStudent();
            break;

        default:
            Console.WriteLine("Select valid option");
            break;
    }

    Console.WriteLine("0.Close App");
    Console.WriteLine("1.Show Students");
    Console.WriteLine("2.Create Student");

    RequestNumber = Console.ReadLine();
}

