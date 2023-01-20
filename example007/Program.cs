Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 1;
int ya = 1;
int xd = 1;
int yd = 30;
int xc = 80;
int yc = 30;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xd, yd);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xd;
 
int count = 10;

while(count < 10000)
{
    int what = new Random().Next(0, 3); //[0;3) 0 1 2
    if (what == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }
    if (what == 1)
    {
        x = (x + xd)/2;
        y = (y + yd)/2;
    }
    if (what == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}

