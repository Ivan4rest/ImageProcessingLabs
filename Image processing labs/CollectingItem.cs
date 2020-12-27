using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Image_processing_labs
{
    public class CollectingItem
    {
        /// <summary>
        /// Список точек, принадлежащих этому собирающему элементу
        /// </summary>
        public List<Point> Points = new List<Point>();

        /// <summary>
        /// Угол между осью X и нормалью в гадусах
        /// </summary>
        private double angleDegree;

        /// <summary>
        /// Угол между осью X и нормалью в гадусах
        /// </summary>
        public double AngleDegree
        {
            set
            {
                if(value > 90)
                {
                    angleDegree = 90;
                }
                else if(value < -90)
                {
                    angleDegree = -90;
                }
                else
                {
                    angleDegree = value;
                }
            }
            get
            {
                return angleDegree;
            }
        }

        /// <summary>
        /// Угол между осью X и нормалью в радианах
        /// </summary>
        public double AngleRadian
        {
            get
            {
                return angleDegree * (Math.PI / 180);
            }
        }

        /// <summary>
        /// Длина нормали к началу координат
        /// </summary>
        public double LengthNormalToTheOrigin { set; get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public CollectingItem(double lengthNormalToTheOrigin, double angleDegree)
        {
            AngleDegree = angleDegree;
            LengthNormalToTheOrigin = lengthNormalToTheOrigin;
        }
    }
}
