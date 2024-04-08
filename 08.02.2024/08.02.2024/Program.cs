using Dapper;

var connectionString = "Data Source=localhost;Initial Catalog=Programmers;Integrated Security = True;";

var ProgrammerAction = new ProgrammerAction(connectionString);
var programmers = ProgrammerAction.GetAllProgrammers();

foreach (var car in programmers)
{
    Console.WriteLine($"Id: {car.Id}, Name: {car.Name}, Model:{car.Surname}");
}