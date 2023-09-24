Console.WriteLine("Write a number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int result = userNum & 2;

Console.WriteLine(result);

if (result != 0) //!= - isn't
{
    Console.WriteLine("User number is odd.");
}
else
{
    Console.WriteLine("USer number is even.");
}