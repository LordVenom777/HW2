

 

 

int a = new Random() .Next(1, 10000);

int b = a / 100;

int c = a % 100 ;

HT (a);





void HT (int a)

{

 

    Console.WriteLine("Рандомное число " + a);

   

if (a > 99 && a < 1000)

{

    Console.WriteLine("Третья цифра "+ a % 10);

}

else if (b == 0)

{

    Console.WriteLine("Третьей цифры нет ");

}

else if (a > 1000)

{

    Console.WriteLine("Третья цифра! "+ c / 10);

}

 

}

 

 

 