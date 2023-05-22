var person = new
{
    Age = 1,
    Name = "Test"
};


var person2 = person with { Age = 2 };




Console.Write(person2.Name);
