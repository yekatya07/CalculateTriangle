using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangle
{
    public class Triangle
    {
        public static (string, int[], int[], int[]) GoTriangle(string first, string second, string third)
        {
            try
            {
                float f = float.Parse(first);
                float s = float.Parse(second);
                float t = float.Parse(third); // конвертируем длины треугольников

                if (f <= 0 || s <= 0 || t <= 0)
                {
                    int[] xy1 = new int[] { -2, -2 };
                    int[] xy2 = new int[] { -2, -2 };
                    int[] xy3 = new int[] { -2, -2 };
                    return ("", xy1, xy2, xy3);
                }

                if (f + s >= t && f + t >= s && s + t >= f) // если конвертируется успешно, проверяем, является ли треугольиком: сумма длины двух сторон в каждом случае должна
                                                            // быть больше, чем длина третьей стороны
                {                                           //случай, при котором у нас условие выполняется корректно, фигура является треугольником
                    string type = "";


                    if (f == t && s == f && s == t) type = "Равносторонний"; // определение типа треугольника по условиям
                    else if (f == s || s == t || f == t) type = "Равнобедренный";
                    else type = "Разносторонний";

                    int[] xy1 = new int[] { 0, 0 }; // первая вершина треугольника лежит в точке (0; 0)
                    int[] xy2 = new int[] { (int)t, 0 }; // следующая по оси ординат находится в точке, а по абциссе отходит от начала координат на длину третьей стороны

                    float cosA = (s * s + t * t - f * f) / (2 * s * t); // для получения третьей координаты по формуле через длины вычислим косинус угла, лежащего между первой и второй сторонами
                    float sinA = (float)Math.Sqrt(1 - cosA * cosA); // по формуле вычислим синус
                    float height = s * sinA; // также по формуле находим высоту по формуле синуса и прилежащей длины

                    float temp = (t * t - s * s + f * f) / (2 * f); // находим координаты третьей вершины
                    int[] xy3 = new int[] { (int)temp, (int)Math.Sqrt(height * height - temp * temp) };

                    if (Math.Max(xy1[0], Math.Max(xy1[1], Math.Max(xy2[0], Math.Max(xy2[1], Math.Max(xy3[0], xy3[1]))))) > 80) // если значение координат выходит за пределы
                    {                                                                                                             // определённого значения, масштабируем
                        int scale = 100 / Math.Max(xy2[0], Math.Max(xy3[0], xy3[1])); // условно, 100 процентов делим на максимальную координату
                        xy1[0] *= scale;
                        xy1[1] *= scale; // домножаем, чтобы масштабировать
                        xy2[0] *= scale;
                        xy2[1] *= scale;
                        xy3[0] *= scale;
                        xy3[1] *= scale;
                    }

                    string msg = $"{type} ({xy1[0]}; {xy1[1]}), ({xy2[0]}; {xy2[1]}), ({xy3[0]}; {xy3[1]})";
                    return (type, xy1, xy2, xy3); // возвращаем значения, логируем
                }
                else
                {
                    int[] xy1 = new int[] { -1, -1 };
                    int[] xy2 = new int[] { -1, -1 };
                    int[] xy3 = new int[] { -1, -1 };
                    string msg = $" Не треугольник (Ф)";
                    return ("Не треугольник", xy1, xy2, xy3);
                }
            }
            catch (Exception ex) // случай, при котором данные не могут быть корректно конвертированы
            {
                int[] xy1 = new int[] { -2, -2 };
                int[] xy2 = new int[] { -2, -2 };
                int[] xy3 = new int[] { -2, -2 };
                string msg = $" ({xy1[0]}; {xy1[1]}), ({xy2[0]}; {xy2[1]}), ({xy3[0]}; {xy3[1]})";
                return ("", xy1, xy2, xy3);
            }
        }
    }

}
