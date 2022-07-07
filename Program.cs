int mayornumber = 0, insertednumber;

Console.WriteLine("Enter the amount of numbers");
int totalnumber = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= totalnumber; i++)
{
    Console.WriteLine("\nInsert a number: ");
    insertednumber = Int32.Parse(Console.ReadLine());

    if(i == 1)
    {
        mayornumber = insertednumber;
    }
    else
    {
        if (insertednumber > mayornumber)
        {
            mayornumber = insertednumber;
        }
    }
} 

Console.WriteLine("\nMayor number: " + mayornumber);