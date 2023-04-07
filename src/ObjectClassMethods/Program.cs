System.Object obj = new Person() { PersonName = "Zack", Email = "zack@email.co.za" };
bool equator = obj.Equals(new Person() { PersonName = "Zack", Email = "zack@email.co.za"});
Console.WriteLine(equator);
Console.WriteLine(obj.ToString());
Console.WriteLine(obj.GetType().ToString());