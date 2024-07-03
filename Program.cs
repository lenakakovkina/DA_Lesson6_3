int guestNumber = 5;
int guestNumberInPlace = 0;
do
{
    Console.WriteLine("Hi! What is your name?");
    string UserName = Console.ReadLine();
    Console.WriteLine($"Nice to meet you {UserName}");
    guestNumberInPlace++;
}
while (guestNumberInPlace != guestNumber);
Console.WriteLine("All guests are here. We can start!");