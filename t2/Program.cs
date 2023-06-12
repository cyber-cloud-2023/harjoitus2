// See https://aka.ms/new-console-template for more information
using t2;

Console.WriteLine("Hello, World!");
Person person = new Person();
person.Name = "Teppo Testi";
person.Age = 22;
person.Welcome("Terve");

Car car = new Car();
car.Brand = "Ford";
car.Speed = 80;
Console.WriteLine(car.Brand+" nopeus = "+car.Speed);
car.Accelerate((float)12.5);
//seuraava toimii jos Speed ja value-parametri ovat double
//tyyppiä
//car.Accelerate(12.5);
Console.WriteLine("Kiihdytyksen jälkeen nopeus = " + car.Speed);