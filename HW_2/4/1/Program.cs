int Find_first (int a){
    int b = a / 10;
    return b;
}
int Find_second (int a){
     int c = a % 10; 
    return c;
}





void Find_digit_and_find_largest(int a, int b, int c) // просто название метода - как процедуры 
{
    // int b = a / 10; // деление целого - 65 = 6
    // int c = a % 10; // нахождение поледн цифры


    Console.WriteLine("Рамддомное цисло - " + a);
    Console.WriteLine(b);
    Console.WriteLine(c);

    if (b > c)
    {
        Console.WriteLine("Наибольшее число " + b);
    }
    else if (b < c)
    {
        Console.WriteLine("Наибольшее число " + c);
    }
    else
    {
        Console.WriteLine("Цифры равны ");
    }
}

// int f = new Random().Next(10, 100);
// int b =  Find_first (f);
// int c =  Find_second  (f);
// Find_digit_and_find_largest (f, b, c);



//  int f = new Random().Next(100);
//  int b =  Find_first (f);
// int c =  Find_second  (f);
// Find_digit_and_find_largest (f, b, c);



 int f = new Random().Next(100);
Find_digit_and_find_largest (f, Find_first (f), Find_second  (f));







// Find_digit_and_find_largest(f);