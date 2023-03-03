/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Clear();
const int COEFFICIENT =0;
const int CONSTANT =1;
const int X_COORD =0;
const int Y_COORD =1;
const int LINE1 = 1;
const int LINE2 = 2;
double[]linedata1 = InputLineData(LINE1);
double[]linedata2=InputLineData(LINE2);
if(Validatelines(linedata1,linedata2))
{
    double[]coord = FindCoords(linedata1,linedata2);
    Console.Write($"Точка пересечения уравнений y={linedata1[COEFFICIENT]}*x+{linedata1[CONSTANT]} и y={linedata2[COEFFICIENT]}*x+{linedata2[CONSTANT]}");
    Console.WriteLine($" Имеет координаты({coord[X_COORD]}, {coord[Y_COORD]})");
}
double Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    double result =Convert.ToDouble(value);
    return result;
}
double[]InputLineData(int numberOfLine)
{
    double[]linedata = new double[2];
    linedata[COEFFICIENT] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
    linedata[CONSTANT] = Prompt($"Введите константу для {numberOfLine} прямой >");
    return linedata;
}
double[]FindCoords(double[]linedata1,double[]linedata2)
{
    double[]coord = new double[2];
    coord[X_COORD]= (linedata1[CONSTANT]-linedata2[CONSTANT])/(linedata2[COEFFICIENT]-linedata1[COEFFICIENT]);
    coord[Y_COORD]=linedata1[CONSTANT]*coord[X_COORD]+linedata1[CONSTANT];
    return coord;
}
bool Validatelines(double[]linedata1, double[]linedata2)
{
    if(linedata1[COEFFICIENT]==linedata2[COEFFICIENT])
    {
        if(linedata1[CONSTANT]==linedata2[CONSTANT])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}