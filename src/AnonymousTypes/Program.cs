using AnonymousObjectsClassLib;

Person p = new Person();

// call methods
var person = new { 
  PersonName = p.GetPersonName(), 
  PersonAge = p.GetPersonAge(), 
  Address = new 
    { 
      Street = "ADC", 
      City = "XCV" 
    } 
};


// anonymous arrays

var newPerson = new[]
{
  new {PersonName = "Zack", Email = "Zack@email.com"},
  new {PersonName = "Luke", Email = "Luke@email.com"},
  new {PersonName = "Stephen", Email = "Stephen@email.com"}
};

// foreach
foreach(var item in newPerson)
{
  Console.WriteLine("{0}, {1}", item.PersonName, item.Email);
}