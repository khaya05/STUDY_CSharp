// generic class
User<int,int> user1 = new User<int,int>();
User<bool, string> user2 = new User<bool,string>();

//set value into generic class
user1.RegistrationStatus = 1234;
user2.RegistrationStatus = false;

user1.Age = 22;
user2.Age = "35 - 40";

Console.WriteLine(user1.RegistrationStatus);
 