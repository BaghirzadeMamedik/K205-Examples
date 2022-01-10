using K205_Examples;
using System.Security.Cryptography;
using System.Text;

// 54as54-d51as4d-5a4sd-54a6-sdas54d-6as4-54d5a
// MD5 sifreleme C#-da

//static string Hash(string password)  // string 
//{
//    using (var sha256 = SHA256.Create())
//    {
//        var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + "istifadeciEMaili"));
//        return BitConverter.ToString(hash).Replace("-","");
//    }
//}


//string sifre = "123";
//string sifre2 = "AAE8BFB9872FE65143FB5E619F5B96200D49BF7D015F107517005C7A9CE51BA9";

//Console.WriteLine(Hash(sifre));

//Console.WriteLine("Sifrenizi daxil edi");

//string parol = Console.ReadLine();

//if (sifre == Hash(parol))
//{
//    Console.WriteLine("Sifre duzdu");
//}
//else
//{
//    Console.WriteLine("Sifre sehfdi");
//}


//User user1 = new User();

//user1.Id = 1;
//user1.Name = "Vahid";
//user1.Surname = "Muradov";
//user1.Password = "1234";







//User user2 = new() { 
//    Id = 2,
//    Name = "Resad",
//    Surname = "Residli",
//    Password = "Resid123"

//};


//User user3 = new();




//Console.Write("Adinizi daxil edin: ");

//string name = Console.ReadLine();

//Console.Write("Sifrenizi daxil: ");

//string password = Console.ReadLine();

//user3.Name = name;
//user3.Password = password;

//Console.WriteLine(user3.Name + " " + user3.Password);

//// class
///


User user1 = new User();

user1.Id = 1;
user1.Name = "Vahid";
user1.Surname = "Muradov";
user1.Password = "1234";


Console.WriteLine(user1.Hash());