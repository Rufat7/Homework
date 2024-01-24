using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.AddJsonFile("appsettings.json");
var config = builder.Build();
using SqlConnection conn = new(config.GetConnectionString("Default"));
conn.Open();

var command = new SqlCommand("select count(*) from Faculties", conn);
{
    int num1 = (int)command.ExecuteScalar();

    Console.WriteLine($"Count of Faculties: {num1}");
}

command = new SqlCommand("select max(CourseYear) from Groups", conn);
{
    var num2 = command.ExecuteScalar();
    Console.WriteLine($"Maximum  CourseYear: {num2}");
}

command = new SqlCommand("select sum(Salary) from Teachers", conn);
{
    var num3 = command.ExecuteScalar();

    Console.WriteLine($"Sum salary: {num3}");
}

command = new SqlCommand("insert into Subject(Name) values(N'Mathematics')", conn);
{
    var num4 = command.ExecuteNonQuery();
     
    Console.WriteLine($"Count of Subjects added: {num4}");
}
 
command = new SqlCommand("delete from Groups where CourseYear = 1", conn);
{
    var num5 = command.ExecuteNonQuery();
     
    Console.WriteLine($"Count of Groups deleted: {num5}");
}
 
command = new SqlCommand("update Teachers set Salary = 1500 where Name = N'Samir'", conn);
{
    var num6 = command.ExecuteNonQuery();
     
    Console.WriteLine($"Count of Teachers updated: {num6}");
}