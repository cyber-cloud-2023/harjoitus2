// See https://aka.ms/new-console-template for more information
/*
 * Luo luokka nimeltä "Person" ja 
 * siihen ominaisuudet "Name" ja "Age". 
 * Luo sitten uusi Person-olio ja aseta sille 
 * nimi ja ikä. Tulosta Person-olion 
 * tiedot konsoliin.
*/
using t1;

Person objectPerson = new Person();
objectPerson.SetName("Teppo Testi");
objectPerson.SetAge(21);
//Console.WriteLine("Anna nimesi");
//objectPerson.SetName(Console.ReadLine());
Console.WriteLine("Nimi="+objectPerson.GetName());
Console.WriteLine("Ikä="+objectPerson.GetAge());
