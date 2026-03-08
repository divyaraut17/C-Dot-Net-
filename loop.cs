// See https://aka.ms/new-console-template for more information

//for(int i=0; i<5; i++)
//{
//    Console.WriteLine(i);
//}


for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Outer: " + i);

    for (int j = 0; j < 6; j++)
    {
        Console.WriteLine("Inner: " + j);
    }
}