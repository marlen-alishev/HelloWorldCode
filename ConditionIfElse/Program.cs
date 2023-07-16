Console.Write("Your name: ");
string username = Console.ReadLine(); 

if (username.ToLower() == "masha")
{
    Console.WriteLine("Hey, Mashallah!!!");
}
else 
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}