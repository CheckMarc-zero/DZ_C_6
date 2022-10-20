double k1 = insertNumber("Задайте параметр к1 в функции y=k1*x+b1:");
double b1 = insertNumber("Задайте параметр b1 в функции y=k1*x+b1:");
double k2 = insertNumber("Задайте параметр к2 в функции y=k2*x+b2:");
double b2 = insertNumber("Задайте параметр b2 в функции y=k2*x+b2:");

double [] needMassiv = tchk(k1,b1,k2,b2);
Console.WriteLine($"Точка пересечения: ({needMassiv[0]};{needMassiv[1]})");

//Метод ввода данных
double insertNumber (string message)
{
    Console.WriteLine(message);
double number = double.Parse(Console.ReadLine());
return number;
}

//Метод вычисления точки пересечения
double [] tchk (double n1,double m1,double n2,double m2 )
{
    double [] massiv = new double [2];
    massiv[0] = (m2-m1)/(k1-k2);
    massiv[1] = n1*massiv[0] + m1;
    return massiv;
}