using AnonymousObjectsClassLib;

Person p = new Person();

// call methods
var person = new { PersonName = p.GetPersonName(), PersonAge = p.GetPersonAge() };