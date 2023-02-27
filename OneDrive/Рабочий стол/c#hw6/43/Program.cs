
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




const int COEF = 0;
const int CONST = 1;
const int X = 0;
const int Y = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoord(lineData1, lineData2);
    Console.Write($"Точка пересечений уравнений y = {lineData1[COEF]} * x + {lineData2[COEF]} и y = {lineData2[COEF]} * x + {lineData2[COEF]}");
    Console.WriteLine($" имеет координаты ({coord[X]}, {coord[Y]})");
}

double Prompt(string text)
{
    Console.Write(text);
    double result = int.Parse(Console.ReadLine()!);
    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEF] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
    lineData[CONST] = Prompt($"Введите константу для {numberOfLine} прямой >");
    return lineData;
}
double[] FindCoord(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X] = ((lineData1[CONST] - lineData2[CONST]) / (lineData2[COEF] - lineData1[COEF]));
    coord[Y] = lineData1[CONST] * coord[X] + lineData1[CONST];
    return coord;
}
bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if(lineData1[COEF] == lineData2[COEF])
    {
        if(lineData1[CONST] == lineData2[CONST])
        {
            Console.Write("Прямые совпадают");
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