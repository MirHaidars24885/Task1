Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");
 
 
 
int a = 11; 
String mac = "Big mac"; 

int [] Mir = { 1,2,3,4,5,6};

static void AverageCalculator(int[] Mir)
{
    double sum = 0;
    foreach (var i in Mir)
    {
        sum += i;

    }

    Console.WriteLine(sum / Mir.Length);

}

static void returnsTheMaximumValue(int[] Mir)
{
    int maxval = Mir[0];
    foreach (var j in Mir)
    {
        if (maxval < j)
        {
            maxval = j; 
        }

    }
    Console.WriteLine(maxval);
}