

 int FindFD (int l)

 {

     int sa = l /10; // Деление нацело 78 = 7

     return sa;

 }



void FindLD ( int s, int sa)

{

    Console.WriteLine("Рандомное число " + s);

    Console.Write (sa %10 );

    // Console.WriteLine (sc);

}

 

int s = new Random().Next(100, 300);

FindLD (s, FindFD(s));





