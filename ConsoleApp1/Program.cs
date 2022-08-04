Console.WriteLine("What is the radius of your circle?");

string rad = Console.ReadLine();

int radius = Int32.Parse(rad);

int Circumference = (int)(2 * 3.14 * radius);

int diameter = (int)(radius * 2);

Console.WriteLine("The circumference of your circle is " + Circumference);

Console.WriteLine("The diameter of your circle is " + diameter);

Console.WriteLine("What is the MPG of your car?");

string mpg = Console.ReadLine();

int milesPerGallon = Int32.Parse(mpg);

int Gallons = (int)(diameter / milesPerGallon);

Console.WriteLine("If the diameter of your circle was miles, it would take you " + Gallons + " gallon(s) of gas to make it all the way around.");