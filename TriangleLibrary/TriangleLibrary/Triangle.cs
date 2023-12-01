namespace TriangleLibrary
{
    public class Triangle
    {

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        //инициилизируем стороны треугольника
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        ///<summary>
        ///Метод, позволяющий определить к какому типу относится треугольник (Треугольный, прямоугольный, тупоугольный)
        /// </summary>
        /// <returns>
        /// TriangleType.Right, TriangleType.Obtuse, TriangleType.Acute
        /// </returns>
        /// <param name="SideA">
        /// Первая сторона треугольника
        /// </param>
        /// <param name="SideB">
        /// Вторая сторона треугольника
        /// </param>
        /// <param name="SideC">
        /// Третья сторона треугольника
        /// </param>

        public TriangleType GetTriangleType()
        {
            double angleA = Math.Acos((SideB * SideB + SideC * SideC - SideA * SideA) / (2 * SideB * SideC)) * (180.0 / Math.PI);
            double angleB = Math.Acos((SideA * SideA + SideC * SideC - SideB * SideB) / (2 * SideA * SideC)) * (180.0 / Math.PI);
            double angleC = Math.Acos((SideA * SideA + SideB * SideB - SideC * SideC) / (2 * SideA * SideB)) * (180.0 / Math.PI);

            if (angleA < 90 && angleB < 90 && angleC < 90)
            {
                return TriangleType.Right;
            }
            else if (angleA > 90 || angleB > 90 || angleC > 90)
            {
                return TriangleType.Obtuse;
            }
            else
            {
                return TriangleType.Acute;
            }
        }



    }

    public enum TriangleType
    {
        Right,
        Acute,
        Obtuse
    }
}
