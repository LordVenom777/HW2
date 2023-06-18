






void FindLarDigit (int a, int fa, int sa)

{

 

Console.WriteLine ("Рандомное число "+ a );

Console.WriteLine ("Первое "+ fa );

Console.WriteLine ("Второе "+ sa );

 

if (fa > sa) {

    Console.WriteLine ("больше " + fa);

}

else if (fa < sa) {

    Console.WriteLine ("больше " + sa);

}

else  {

    Console.WriteLine ("равны");

}

}

 

int x = new Random().Next(10, 100);

FindLarDigit (x, FindFD (x),FindSD (x));

 

// // int x1 = new Random().Next(100);

// // int fa = FindFD (x1);

// // int sa = FindSD (x1);

// // FindLarDigit (x1, fa,sa);

 

// // int x2 = new Random().Next(-70, 10);

// // int fa = FindFD (x2);

// // int sa = FindSD (x2);

// // FindLarDigit (x2, fa,sa);

 