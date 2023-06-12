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

//Person2 luokass Propertyt Name ja Age
//korvaavat Person luokan privaatti muuttujat
//ja niiden getter ja setter metodit
Person2 objectPerson2 = new Person2();  
objectPerson2.Age = 24;
objectPerson2.Name = "Matti Virta";
Console.WriteLine("Person2 nimi=" + objectPerson2.Name);
Console.WriteLine("Person2 ikä="+objectPerson2.Age);
