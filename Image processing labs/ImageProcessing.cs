using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Image_processing_labs
{
    public class ImageProcessing
    {
        static Random rnd = new Random();

        /// <summary>
        /// Сортирует массив в порядке возрастания
        /// </summary>
        public static List<int> QuickSort(List<int> numbers, int left, int right)
        {
            int pivot;
            int l_hold = left;
            int r_hold = right;
            pivot = numbers[left];
            while (left < right)
            {
                while ((numbers[right] >= pivot) && (left < right))
                    right--;
                if (left != right)
                {
                    numbers[left] = numbers[right];
                    left++;
                }
                while ((numbers[left] <= pivot) && (left < right))
                    left++;
                if (left != right)
                {
                    numbers[right] = numbers[left];
                    right--;
                }
            }
            numbers[left] = pivot;
            pivot = left;
            left = l_hold;
            right = r_hold;
            if (left < pivot)
                QuickSort(numbers, left, pivot - 1);
            if (right > pivot)
                QuickSort(numbers, pivot + 1, right);

            return numbers;
        }

        /// <summary>
        /// Метод преобразует изображение в градации серого
        /// </summary>
        public static Bitmap ToGrey(Bitmap bmp)
        {
            Bitmap bmp_output = new Bitmap(bmp.Width, bmp.Height);
            for (int y = 0; y < bmp.Height; ++y)
                for (int x = 0; x < bmp.Width; ++x)
                {
                    Color col = bmp.GetPixel(x, y);
                    int r = col.R, g = col.G, b = col.B;
                    int br = (r + g + b) / 3;
                    col = Color.FromArgb(br, br, br);
                    bmp_output.SetPixel(x, y, col);
                }
            return bmp_output;
        }

        /// <summary>
        /// Возврващает синтезируемое изображение плоской волны в градациях серого
        /// </summary>
        public static Bitmap GetSynthesizedImagePlaneWaveInGrayscale(int width, int height, double u, double v)
        {
            Bitmap bmp = new Bitmap(width, height);

            int A = 70;
            int B = 128;

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    int L = (int)(A * Math.Cos(u * x + v * y) + B);
                    Color color = Color.FromArgb(L, L, L);
                    bmp.SetPixel(x, y, color);
                }
            }
            return bmp;
        }

        /// <summary>
        /// Возврващает треугольник Максвелла
        /// </summary>
        public static Bitmap GetMaxwellTriangle()
        {
            Bitmap bmp_output = new Bitmap(256, 256);

            for (int g = 0; g < 255; g++)
                for (int r = 0; r < 255 - g; r++)
                {
                    Color color = Color.FromArgb(r, g, 255 - r - g);
                    bmp_output.SetPixel(r, g, color);
                }

            return bmp_output;
        }

        #region Gauss noise

        /// <summary>
        /// Возвращает случайную величину, распределенную по Гауссовскому закону
        /// </summary>
        public static double GetRandomNumber()
        {
            double sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum += rnd.NextDouble();
            }
            return (sum - 6);
        }

        /// <summary>
        /// Добавляет на изображение не цветной шум Гаусса
        /// </summary>
        public static Bitmap GaussNoiseNotColor(Bitmap bmp, int intensity)
        {
            Bitmap bmp_output = new Bitmap(bmp.Width, bmp.Height);
            Color color;          
            double d;
            int r, g, b;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    d = GetRandomNumber();
                    color = bmp.GetPixel(i, j);
                    r = color.R + (int)(d * intensity);
                    g = color.G + (int)(d * intensity);
                    b = color.B + (int)(d * intensity);
                    if (r > 255)
                        r = 255;
                    else if (r < 0)
                        r = 0;
                    if (g > 255)
                        g = 255;
                    else if (g < 0)
                        g = 0;
                    if (b > 255)
                        b = 255;
                    else if (b < 0)
                        b = 0;
                    color = Color.FromArgb(r, g, b);
                    bmp_output.SetPixel(i, j, color);
                }
            }
            return bmp_output;
        }

        /// <summary>
        /// Добавляет на изображение цветной шум Гаусса
        /// </summary>
        public static Bitmap GaussNoiseColor(Bitmap bmp, int intensity)
        {
            Bitmap bmp_output = new Bitmap(bmp.Width, bmp.Height);
            Color color;
            int r, g, b;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    color = bmp.GetPixel(i, j);
                    r = color.R + (int)(GetRandomNumber() * intensity);
                    g = color.G + (int)(GetRandomNumber() * intensity);
                    b = color.B + (int)(GetRandomNumber() * intensity);
                    if (r > 255)
                        r = 255;
                    else if (r < 0)
                        r = 0;
                    if (g > 255)
                        g = 255;
                    else if (g < 0)
                        g = 0;
                    if (b > 255)
                        b = 255;
                    else if (b < 0)
                        b = 0;
                    color = Color.FromArgb(r, g, b);
                    bmp_output.SetPixel(i, j, color);
                }
            }
            return bmp_output;
        }

        #endregion

        #region Interferences

        /// <summary>
        /// Возвращает список случайных точек
        /// </summary>
        public static List<Point> GetRandomListPoints(int width, int height, int countPoints)
        {
            List<Point> points = new List<Point>();

            if (countPoints > width * height)
                countPoints = width * height;

            while (countPoints > 0)
            {
                Point point = new Point();
                point.X = rnd.Next(width);
                point.Y = rnd.Next(height);
                if (!points.Contains(point))
                {
                    points.Add(point);
                    countPoints--;
                }
            }
            return points;
        }

        /// <summary>
        /// Добавляет на изображение помеху типа "соль"
        /// </summary>
        public static Bitmap SaltInterference(Bitmap bmp, int intensityInterference)
        {
            List<Point> pixels = GetRandomListPoints(bmp.Width, bmp.Height, intensityInterference);
            for (int i = 0; i < pixels.Count; i++)
            {
                bmp.SetPixel(pixels[i].X, pixels[i].Y, Color.White);
            }
            return bmp;
        }

        /// <summary>
        /// Добавляет на изображение помеху типа "перец"
        /// </summary>
        public static Bitmap PepperInterference(Bitmap bmp, int intensityInterference)
        {
            List<Point> pixels = GetRandomListPoints(bmp.Width, bmp.Height, intensityInterference);
            for (int i = 0; i < pixels.Count; i++)
            {
                bmp.SetPixel(pixels[i].X, pixels[i].Y, Color.Black);
            }
            return bmp;
        }

        /// <summary>
        /// Добавляет на изображение помеху типа "соль-перец"
        /// </summary>
        public static Bitmap SaltPepperInterference(Bitmap bmp, int intensityInterference)
        {
            List<Point> pixels = GetRandomListPoints(bmp.Width, bmp.Height, intensityInterference);
            for (int i = 0; i < pixels.Count; i++)
            {
                int b = rnd.Next(2);
                if (b == 0)
                    bmp.SetPixel(pixels[i].X, pixels[i].Y, Color.White);
                else
                    bmp.SetPixel(pixels[i].X, pixels[i].Y, Color.Black);
            }
            return bmp;
        }

        #endregion


        /// <summary>
        /// Размер апертуры
        /// </summary>
        public static int apertureSize;

        /// <summary>
        /// Расширяет картинку
        /// </summary>
        public static Bitmap ExtendPicture(Bitmap bmpInput)
        {
            int extendValue = apertureSize / 2;
            Bitmap bmpOutput = new Bitmap(bmpInput.Width + 2 * extendValue, bmpInput.Height + 2 * extendValue);

            for (int i = extendValue; i >= 0; i--)
            {
                for (int y = i; y < bmpOutput.Height - i; y++)
                {
                    for (int x = i; x < bmpOutput.Width - i; x++)
                    {
                        //Копирует исходное изображение
                        if (i == extendValue)
                        {
                            bmpOutput.SetPixel(x, y, bmpInput.GetPixel(x - i, y - i));
                        }
                        //Добавляем левый верхний угловой пиксель
                        if (x < extendValue && y < extendValue)
                        {
                            bmpOutput.SetPixel(x, y, bmpOutput.GetPixel(x + 1, y + 1));
                        }
                        //Добавляем правый верхний угловой пиксель
                        else if (x >= (bmpOutput.Width - extendValue) && y < extendValue)
                        {
                            bmpOutput.SetPixel(x, y, bmpOutput.GetPixel(x - 1, y + 1));
                        }
                        //Добавляем левый нижний угловой пиксель
                        else if (x < extendValue && y >= (bmpOutput.Height - extendValue))
                        {
                            bmpOutput.SetPixel(x, y, bmpOutput.GetPixel(x + 1, y - 1));
                        }
                        //Добавляем правый нижний угловой пиксель
                        else if (x >= (bmpOutput.Width - extendValue) && y >= (bmpOutput.Height - extendValue))
                        {
                            bmpOutput.SetPixel(x, y, bmpOutput.GetPixel(x - 1, y - 1));
                        }
                        //Добавляем верхние пиксели
                        else if (x >= extendValue && x < (bmpOutput.Width - extendValue) && y < extendValue)
                        {
                            bmpOutput.SetPixel(x, y, bmpOutput.GetPixel(x, y + 1));
                        }
                        //Добавляем нижние пиксели
                        else if (x >= extendValue && x < (bmpOutput.Width - extendValue) && y >= (bmpOutput.Height - extendValue))
                        {
                            bmpOutput.SetPixel(x, y, bmpOutput.GetPixel(x, y - 1));
                        }
                        //Добавляем левые пиксели
                        else if (x < extendValue && y >= extendValue && y < (bmpOutput.Height - extendValue))
                        {
                            bmpOutput.SetPixel(x, y, bmpOutput.GetPixel(x + 1, y));
                        }
                        //Добавляем правые пиксели
                        else if (x >= (bmpOutput.Width - extendValue) && y >= extendValue && y < (bmpOutput.Height - extendValue))
                        {
                            bmpOutput.SetPixel(x, y, bmpOutput.GetPixel(x - 1, y));
                        }
                    }
                }
            }

            return bmpOutput;
        }

        /// <summary>
        /// Обрезает картинку
        /// </summary>
        public static Bitmap CutPicture(Bitmap bmpInput)
        {
            int cutValue = apertureSize / 2;
            Bitmap bmpOutput = new Bitmap(bmpInput.Width - 2 * cutValue, bmpInput.Height - 2 * cutValue);

            for (int y = 0; y < bmpOutput.Height; y++)
            {
                for (int x = 0; x < bmpOutput.Width; x++)
                {
                    bmpOutput.SetPixel(x, y, bmpInput.GetPixel(x + cutValue, y + cutValue));
                }
            }

            return bmpOutput;
        }

        /// <summary>
        /// Возвращает критерия качества реставрации
        /// </summary>
        public static double GetCriterionQualityRestoration(Bitmap bmpOriginal, Bitmap bmpRenovated)
        {
            double criterionQualityRestoration = 0;
            for (int y = 0; y < bmpOriginal.Height; y++)
            {
                for (int x = 0; x < bmpOriginal.Width; x++)
                {
                    criterionQualityRestoration += ((bmpRenovated.GetPixel(x, y).R + bmpRenovated.GetPixel(x, y).G + bmpRenovated.GetPixel(x, y).B) / 3 - (bmpOriginal.GetPixel(x, y).R + bmpOriginal.GetPixel(x, y).G + bmpOriginal.GetPixel(x, y).B) / 3) *
                                                   ((bmpRenovated.GetPixel(x, y).R + bmpRenovated.GetPixel(x, y).G + bmpRenovated.GetPixel(x, y).B) / 3 - (bmpOriginal.GetPixel(x, y).R + bmpOriginal.GetPixel(x, y).G + bmpOriginal.GetPixel(x, y).B) / 3);
                }
            }
            criterionQualityRestoration /= (bmpOriginal.Width * bmpOriginal.Height);

            return criterionQualityRestoration;
        }

        #region Low frequency filter

        static double w1;
        static double w2;
        static double w3;

        /// <summary>
        /// Задает элементы апертуры для низкочастотного фильтра
        /// </summary>
        public static void SetApertureElementsForLowFrequencyFilter(double CKO)
        {
            switch (CKO)
            {
                case 0.5:
                    w1 = 0.44;
                    w2 = 0.07;
                    w3 = 0.0;
                    break;
                case 0.7:
                    w1 = 0.27;
                    w2 = 0.08;
                    w3 = 0.005;
                    break;
                case 1.0:
                    w1 = 0.15;
                    w2 = 0.06;
                    w3 = 0.02;
                    break;
                case 1.25:
                    w1 = 0.1;
                    w2 = 0.06;
                    w3 = 0.02;
                    break;
                case 2.0:
                    w1 = 0.06;
                    w2 = 0.045;
                    w3 = 0.03;
                    break;
                case 2.5:
                    w1 = 0.06;
                    w2 = 0.06;
                    w3 = 0.025;
                    break;
            }
        }

        /// <summary>
        /// Возвращает цвет для низкочастотного фильтра
        /// </summary>
        static Color GetColorLowFrequencyFilter(Bitmap bmp, Point point)
        {
            int extendValue = apertureSize / 2;
            int r = 0;
            int g = 0;
            int b = 0;

            for (int y = (point.Y - extendValue), i = 0; y <= (point.Y + extendValue); y++, i++)
            {
                for (int x = (point.X - extendValue), j = 0; x <= (point.X + extendValue); x++, j++)
                {
                    if(i == 0 || i == 4 || j == 0 || j == 4)
                    {
                        r += (int)(bmp.GetPixel(x, y).R * w3);
                        g += (int)(bmp.GetPixel(x, y).G * w3);
                        b += (int)(bmp.GetPixel(x, y).B * w3);
                    }
                    else if (i == 2 && j == 2)
                    {
                        r += (int)(bmp.GetPixel(x, y).R * w1);
                        g += (int)(bmp.GetPixel(x, y).G * w1);
                        b += (int)(bmp.GetPixel(x, y).B * w1);
                    }
                    else
                    {
                        r += (int)(bmp.GetPixel(x, y).R * w2);
                        g += (int)(bmp.GetPixel(x, y).G * w2);
                        b += (int)(bmp.GetPixel(x, y).B * w2);
                    }
                }
            }
            if (r > 255)
                r = 255;
            else if (r < 0)
                r = 0;

            if (g > 255)
                g = 255;
            else if (g < 0)
                g = 0;

            if (b > 255)
                b = 255;
            else if (b < 0)
                b = 0;

            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// Линейный низкочастотный фильтр
        /// </summary>
        public static Bitmap LinearLowFrequencyFilter(Bitmap bmpInput)
        {
            Bitmap bmp = ExtendPicture(bmpInput);
            int extendValue = apertureSize / 2;
            Bitmap bmpOutput = new Bitmap(bmp.Width, bmp.Height);

            for (int y = extendValue; y < (bmp.Height- extendValue); y++)
            {
                for (int x = extendValue; x < (bmp.Width - extendValue); x++)
                {
                    bmpOutput.SetPixel(x, y, GetColorLowFrequencyFilter(bmp, new Point(x, y)));
                }
            }

            return CutPicture(bmpOutput);
        }

        /// <summary>
        /// Рекурсивный низкочастотный фильтр
        /// </summary>
        public static Bitmap RecursiveLowFrequencyFilter(Bitmap bmpInput)
        {
            Bitmap bmp = ExtendPicture(bmpInput);
            int extendValue = apertureSize / 2;

            for (int y = extendValue; y < (bmp.Height - extendValue); y++)
            {
                for (int x = extendValue; x < (bmp.Width - extendValue); x++)
                {
                    bmp.SetPixel(x, y, GetColorLowFrequencyFilter(bmp, new Point(x, y)));
                }
            }

            return CutPicture(bmp);
        }

        #endregion

        /// <summary>
        /// Массив содержащий элементы апертуры
        /// </summary>
        static int[,] apertureElements;

        #region High frequency filter

        /// <summary>
        /// Задает элементы апертуры для высокочастотного фильтра
        /// </summary>
        public static void SetApertureElementsForHighFrequencyFilter(int mask)
        {
            switch (mask)
            {
                case 1:
                    apertureElements = new int[3, 3] { { 1, -2, 1 }, { -2, 5, -2 }, { 1, -2, 1 } };
                    break;
                case 2:
                    apertureElements = new int[3, 3] { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
                    break;
                case 3:
                    apertureElements = new int[3, 3] { { -1, -1, -1 }, { -1, 9, -1 }, { -1, -1, -1 } };
                    break;
            }
        }

        /// <summary>
        /// Возвращает цвет для высокочастотного фильтра
        /// </summary>
        static Color GetColorHighFrequencyFilter(Bitmap bmp, Point point)
        {
            int extendValue = apertureSize / 2;
            int r = 0;
            int g = 0;
            int b = 0;

            for (int y = (point.Y - extendValue), i = 0; y <= (point.Y + extendValue); y++, i++)
            {
                for (int x = (point.X - extendValue), j = 0; x <= (point.X + extendValue); x++, j++)
                {
                    r += (int)(bmp.GetPixel(x, y).R * apertureElements[i, j]);
                    g += (int)(bmp.GetPixel(x, y).G * apertureElements[i, j]);
                    b += (int)(bmp.GetPixel(x, y).B * apertureElements[i, j]);
                }
            }
            if (r > 255)
                r = 255;
            else if (r < 0)
                r = 0;

            if (g > 255)
                g = 255;
            else if (g < 0)
                g = 0;

            if (b > 255)
                b = 255;
            else if (b < 0)
                b = 0;

            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// Высокочастотный фильтр
        /// </summary>
        public static Bitmap HighFrequencyFilter(Bitmap bmpInput)
        {
            Bitmap bmp = ExtendPicture(bmpInput);
            int extendValue = apertureSize / 2;
            Bitmap bmpOutput = new Bitmap(bmp.Width, bmp.Height);

            for (int y = extendValue; y < (bmp.Height - extendValue); y++)
            {
                for (int x = extendValue; x < (bmp.Width - extendValue); x++)
                {
                    bmpOutput.SetPixel(x, y, GetColorHighFrequencyFilter(bmp, new Point(x, y)));
                }
            }

            return CutPicture(bmpOutput);
        }

        #endregion

        #region Median filter

        /// <summary>
        /// Возвращает цвет для медианного фильтра с прямоугольной апертурой
        /// </summary>
        static Color GetColorMedianFilterRectangle(Bitmap bmp, Point point)
        {
            int extendValue = apertureSize / 2;

            List<int> r = new List<int>();
            List<int> g = new List<int>();
            List<int> b = new List<int>();

            for (int y = (point.Y - extendValue); y <= (point.Y + extendValue); y++)
            {
                for (int x = (point.X - extendValue); x <= (point.X + extendValue); x++)
                {
                    r.Add(bmp.GetPixel(x, y).R);
                    g.Add(bmp.GetPixel(x, y).G);
                    b.Add(bmp.GetPixel(x, y).B);
                }
            }

            r = QuickSort(r, 0, r.Count - 1);
            g = QuickSort(g, 0, g.Count - 1);
            b = QuickSort(b, 0, b.Count - 1);

            return Color.FromArgb(r[r.Count / 2], g[g.Count / 2], b[b.Count / 2]);
        }

        /// <summary>
        /// Возвращает цвет для медианного фильтра с крестообразной апертурой
        /// </summary>
        static Color GetColorMedianFilterCross(Bitmap bmp, Point point)
        {
            int extendValue = apertureSize / 2;

            List<int> r = new List<int>();
            List<int> g = new List<int>();
            List<int> b = new List<int>();

            for (int y = (point.Y - extendValue); y <= (point.Y + extendValue); y++)
            {
                for (int x = (point.X - extendValue); x <= (point.X + extendValue); x++)
                {
                    if (y == point.Y || x == point.X)
                    {
                        r.Add(bmp.GetPixel(x, y).R);
                        g.Add(bmp.GetPixel(x, y).G);
                        b.Add(bmp.GetPixel(x, y).B);
                    }
                }
            }

            r = QuickSort(r, 0, r.Count - 1);
            g = QuickSort(g, 0, g.Count - 1);
            b = QuickSort(b, 0, b.Count - 1);

            return Color.FromArgb(r[r.Count / 2], g[g.Count / 2], b[b.Count / 2]);
        }

        /// <summary>
        /// Возвращает цвет для медианного фильтра с крестообразной по диагонали апертурой
        /// </summary>
        static Color GetColorMedianFilterDiagonalCross(Bitmap bmp, Point point)
        {
            int extendValue = apertureSize / 2;

            List<int> r = new List<int>();
            List<int> g = new List<int>();
            List<int> b = new List<int>();

            for (int y = (point.Y - extendValue), i = 0; y <= (point.Y + extendValue); y++, i++)
            {
                for (int x = (point.X - extendValue), j = 0; x <= (point.X + extendValue); x++, j++)
                {
                    if (i == j || (i + j) == (apertureSize - 1))
                    {
                        r.Add(bmp.GetPixel(x, y).R);
                        g.Add(bmp.GetPixel(x, y).G);
                        b.Add(bmp.GetPixel(x, y).B);
                    }
                }
            }

            r = QuickSort(r, 0, r.Count - 1);
            g = QuickSort(g, 0, g.Count - 1);
            b = QuickSort(b, 0, b.Count - 1);

            return Color.FromArgb(r[r.Count / 2], g[g.Count / 2], b[b.Count / 2]);
        }

        /// <summary>
        /// Медианный фильтр
        /// </summary>
        public static Bitmap MedianFilter(Bitmap bmpInput, string apertureForm)
        {
            Bitmap bmp = ExtendPicture(bmpInput);
            int extendValue = apertureSize / 2;
            Bitmap bmpOutput = new Bitmap(bmp.Width, bmp.Height);

            for (int y = extendValue; y < (bmp.Height - extendValue); y++)
            {
                for (int x = extendValue; x < (bmp.Width - extendValue); x++)
                {
                    switch (apertureForm)
                    {
                        case "rectangle":
                            bmpOutput.SetPixel(x, y, GetColorMedianFilterRectangle(bmp, new Point(x, y)));
                            break;
                        case "cross":
                            bmpOutput.SetPixel(x, y, GetColorMedianFilterCross(bmp, new Point(x, y)));
                            break;
                        case "diagonal cross":
                            bmpOutput.SetPixel(x, y, GetColorMedianFilterDiagonalCross(bmp, new Point(x, y)));
                            break;
                    }
                }
            }

            return CutPicture(bmpOutput);
        }

        #endregion

        #region Differentiation

        /// <summary>
        /// Горизонтальный оператор Собеля
        /// </summary>
        static int[,] HorizontalSobelOperator = new int[3, 3] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };

        /// <summary>
        /// Вертикальный оператор Собеля
        /// </summary>
        static int[,] VerticalSobelOperator = new int[3, 3] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };

        /// <summary>
        /// Возвращает цвет для преобразования горизонтальным оператором Собеля
        /// </summary>
        static Color GetColorGradientHorizontal(Bitmap bmp, Point point)
        {
            int extendValue = apertureSize / 2;
            int r = 0;
            int g = 0;
            int b = 0;

            for (int y = (point.Y - extendValue), i = 0; y <= (point.Y + extendValue); y++, i++)
            {
                for (int x = (point.X - extendValue), j = 0; x <= (point.X + extendValue); x++, j++)
                {
                    r += (int)(bmp.GetPixel(x, y).R * HorizontalSobelOperator[i, j]);
                    g += (int)(bmp.GetPixel(x, y).G * HorizontalSobelOperator[i, j]);
                    b += (int)(bmp.GetPixel(x, y).B * HorizontalSobelOperator[i, j]);
                }
            }

            if (r > 255)
                r = 255;
            else if (r < 0)
                r = 0;

            if (g > 255)
                g = 255;
            else if (g < 0)
                g = 0;

            if (b > 255)
                b = 255;
            else if (b < 0)
                b = 0;

            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// Возвращает цвет для преобразования вертикальным оператором Собеля
        /// </summary>
        static Color GetColorGradientVertical(Bitmap bmp, Point point)
        {
            int extendValue = apertureSize / 2;
            int r = 0;
            int g = 0;
            int b = 0;

            for (int y = (point.Y - extendValue), i = 0; y <= (point.Y + extendValue); y++, i++)
            {
                for (int x = (point.X - extendValue), j = 0; x <= (point.X + extendValue); x++, j++)
                {
                    r += (int)(bmp.GetPixel(x, y).R * VerticalSobelOperator[i, j]);
                    g += (int)(bmp.GetPixel(x, y).G * VerticalSobelOperator[i, j]);
                    b += (int)(bmp.GetPixel(x, y).B * VerticalSobelOperator[i, j]);
                }
            }
            if (r > 255)
                r = 255;
            else if (r < 0)
                r = 0;

            if (g > 255)
                g = 255;
            else if (g < 0)
                g = 0;

            if (b > 255)
                b = 255;
            else if (b < 0)
                b = 0;

            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// Возвращает модуль цветов
        /// </summary>
        static Color GetModul(Color color1, Color color2)
        {
            int r = (int)Math.Sqrt(color1.R * color1.R + color2.R * color2.R);
            int g = (int)Math.Sqrt(color1.G * color1.G + color2.G * color2.G);
            int b = (int)Math.Sqrt(color1.B * color1.B + color2.B * color2.B);

            if (r > 255)
                r = 255;
            else if (r < 0)
                r = 0;

            if (g > 255)
                g = 255;
            else if (g < 0)
                g = 0;

            if (b > 255)
                b = 255;
            else if (b < 0)
                b = 0;

            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// Преобразует горизонтальным оператором Собеля
        /// </summary>
        public static Bitmap GradientHorizontal(Bitmap bmpInput)
        {
            Bitmap bmp = ExtendPicture(bmpInput);
            int extendValue = apertureSize / 2;
            Bitmap bmpOutput = new Bitmap(bmp.Width, bmp.Height);

            for (int y = extendValue; y < (bmp.Height - extendValue); y++)
            {
                for (int x = extendValue; x < (bmp.Width - extendValue); x++)
                {
                    bmpOutput.SetPixel(x, y, GetColorGradientHorizontal(bmp, new Point(x, y)));
                }
            }

            return CutPicture(bmpOutput);
        }

        /// <summary>
        /// Преобразует вертикальным оператором Собеля
        /// </summary>
        public static Bitmap GradientVertical(Bitmap bmpInput)
        {
            Bitmap bmp = ExtendPicture(bmpInput);
            int extendValue = apertureSize / 2;
            Bitmap bmpOutput = new Bitmap(bmp.Width, bmp.Height);

            for (int y = extendValue; y < (bmp.Height - extendValue); y++)
            {
                for (int x = extendValue; x < (bmp.Width - extendValue); x++)
                {
                    bmpOutput.SetPixel(x, y, GetColorGradientVertical(bmp, new Point(x, y)));
                }
            }

            return CutPicture(bmpOutput);
        }

        /// <summary>
        /// Возвращает модуль градиента
        /// </summary>
        public static Bitmap GradientModul(Bitmap bmpInput)
        {
            Bitmap bmp = ExtendPicture(bmpInput);
            int extendValue = apertureSize / 2;
            Bitmap bmpOutput = new Bitmap(bmp.Width, bmp.Height);
            Bitmap bmpOutput1 = new Bitmap(bmp.Width, bmp.Height);
            Bitmap bmpOutput2 = new Bitmap(bmp.Width, bmp.Height);

            for (int y = extendValue; y < (bmp.Height - extendValue); y++)
            {
                for (int x = extendValue; x < (bmp.Width - extendValue); x++)
                {
                    bmpOutput.SetPixel(x, y, GetModul(GetColorGradientHorizontal(bmp, new Point(x, y)), GetColorGradientVertical(bmp, new Point(x, y))));
                }
            }

            return CutPicture(bmpOutput);
        }

        /// <summary>
        /// Задает элементы апертуры для Лапласиана
        /// </summary>
        public static void SetApertureElementsForLaplacian(int mask)
        {
            switch (mask)
            {
                case 1:
                    apertureElements = new int[3, 3] { { 0, 1, 0 }, { 1, -4, 1 }, { 0, 1, 0 } };
                    break;
                case 2:
                    apertureElements = new int[3, 3] { { 1, 0, 1 }, { 0, -4, 0 }, { 1, 0, 1 } };
                    break;
                case 3:
                    apertureElements = new int[3, 3] { { 1, 4, 1 }, { 4, -20, 4 }, { 1, 4, 1 } };
                    break;
            }
        }

        /// <summary>
        /// Возвращает цвет для Лапласиана
        /// </summary>
        static Color GetColorForLaplacian(Bitmap bmp, Point point)
        {
            int extendValue = apertureSize / 2;
            int r = 0;
            int g = 0;
            int b = 0;

            for (int y = (point.Y - extendValue), i = 0; y <= (point.Y + extendValue); y++, i++)
            {
                for (int x = (point.X - extendValue), j = 0; x <= (point.X + extendValue); x++, j++)
                {
                    r += (int)(bmp.GetPixel(x, y).R * apertureElements[i, j]);
                    g += (int)(bmp.GetPixel(x, y).G * apertureElements[i, j]);
                    b += (int)(bmp.GetPixel(x, y).B * apertureElements[i, j]);
                }
            }
            if (r > 255)
                r = 255;
            else if (r < 0)
                r = 0;

            if (g > 255)
                g = 255;
            else if (g < 0)
                g = 0;

            if (b > 255)
                b = 255;
            else if (b < 0)
                b = 0;

            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// Лапласиан
        /// </summary>
        public static Bitmap Laplacian(Bitmap bmpInput)
        {
            Bitmap bmp = ExtendPicture(bmpInput);
            int extendValue = apertureSize / 2;
            Bitmap bmpOutput = new Bitmap(bmp.Width, bmp.Height);

            for (int y = extendValue; y < (bmp.Height - extendValue); y++)
            {
                for (int x = extendValue; x < (bmp.Width - extendValue); x++)
                {
                    bmpOutput.SetPixel(x, y, GetColorForLaplacian(bmp, new Point(x, y)));
                }
            }

            return CutPicture(bmpOutput);
        }

        #endregion

        #region Hough transform

        /// <summary>
        /// Возвращает яркость пикселя
        /// </summary>
        private static int GetBrightPixel(Color color)
        {
            return (int)((color.R + color.G +color.B) / 3);
        }

        static CollectingItem[,] collectingItems;

        /// <summary>
        /// Преобразование Хоуга
        /// </summary>
        public static Bitmap HoughTransform(Bitmap bmp_input, int thresholdBrightness, int thresholdNumberPoints)
        {
            int Rm = Convert.ToInt32(Math.Sqrt(bmp_input.Width * bmp_input.Width + bmp_input.Height * bmp_input.Height));

            collectingItems = new CollectingItem[Rm * 2 + 1, 90 * 2 + 1];

            for (int p = -Rm, i = 0; p <= Rm; p++, i++)
            {
                for (int w = -90, j = 0; w <= 90; w++, j++)
                {
                    collectingItems[i, j] = new CollectingItem(p, w);
                }
            }

            for (int y = 0; y < bmp_input.Height; y++)
            {
                for (int x = 0; x < bmp_input.Width; x++)
                {
                    if (GetBrightPixel(bmp_input.GetPixel(x, y)) >= thresholdBrightness)
                    {
                        for (int i = 0; i < collectingItems.GetLength(0); i++)
                        {
                            for (int j = 0; j < collectingItems.GetLength(1); j++)
                            {
                                if (((x * Math.Cos(collectingItems[i, j].AngleRadian) + y * Math.Sin(collectingItems[i, j].AngleRadian)) > (collectingItems[i, j].LengthNormalToTheOrigin - 0.5)) &&
                                    ((x * Math.Cos(collectingItems[i, j].AngleRadian) + y * Math.Sin(collectingItems[i, j].AngleRadian)) < (collectingItems[i, j].LengthNormalToTheOrigin + 0.5)))
                                {
                                    collectingItems[i, j].Points.Add(new Point(x, y));
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < collectingItems.GetLength(0); i++)
            {
                for (int j = 0; j < collectingItems.GetLength(1); j++)
                {
                    if (collectingItems[i, j].Points.Count > thresholdNumberPoints)
                    {
                        for (int k = 0; k < collectingItems[i, j].Points.Count; k++)
                        {
                            bmp_input.SetPixel(collectingItems[i, j].Points[k].X, collectingItems[i, j].Points[k].Y, Color.Red);
                        }
                    }
                }
            }

            return bmp_input;
        }

        /// <summary>
        /// Возвращает изображение параметрического пространства
        /// </summary>
        public static Bitmap GetBitmapParameterSpace()
        {
            Bitmap bmp_output = new Bitmap(collectingItems.GetLength(1), collectingItems.GetLength(0));

            int r = 0;
            int g = 0;
            int b = 0;

            for (int i = 0; i < collectingItems.GetLength(0); i++)
            {
                for (int j = 0; j < collectingItems.GetLength(1); j++)
                {
                    r = collectingItems[i, j].Points.Count;
                    g = collectingItems[i, j].Points.Count;
                    b = collectingItems[i, j].Points.Count;

                    if (r > 255)
                        r = 255;
                    else if (r < 0)
                        r = 0;
                    if (g > 255)
                        g = 255;
                    else if (g < 0)
                        g = 0;
                    if (b > 255)
                        b = 255;
                    else if (b < 0)
                        b = 0;

                    bmp_output.SetPixel(j, i, Color.FromArgb(r, g, b));
                }
            }

            return bmp_output;
        }

        #endregion
    }
}
