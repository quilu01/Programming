﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются ли прямоугольники.
        /// </summary>
        /// <param name="rectangle1">Экземпляр класса <see cref="Rectangles"/></param>
        /// <param name="rectangle2">Экземпляр класса <see cref="Rectangles"/</param>
        /// <returns>Возвращает значение true если прямуольники пересекаются, и значение false если нет.</returns>
        public static bool IsCollision(Rectangles rectangle1, Rectangles rectangle2)
        {
            // Проверяем, если какой-то из прямоугольников находится слева, справа, выше или ниже другого
            if (rectangle1.Center.X + rectangle1.Widht < rectangle2.Center.X || rectangle2.Center.X + rectangle2.Widht < rectangle1.Center.X || rectangle1.Center.Y + rectangle1.Height < rectangle2.Center.Y || rectangle2.Center.Y + rectangle2.Height < rectangle1.Center.Y)
            {
                // Прямоугольники не пересекаются
                return false;
            }

            // Если ни одно из условий выше не выполнилось, значит прямоугольники пересекаются
            return true;
        }
        /// <summary>
        /// Проверяет, пересекаются ли кольца.
        /// </summary>
        /// <param name="ring1">Экземпляр класса <see cref="Ring"/></param>
        /// <param name="ring2">Экземпляр класса <see cref="Ring"/></param>
        /// <returns>Возвращает значение true если кольца пересекаются, и значение false если нет.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double c = Math.Sqrt(Math.Pow(Math.Abs(ring1.Center.X - ring2.Center.X), 2) + Math.Pow(Math.Abs(ring1.Center.Y - ring2.Center.Y), 2));
            if (c < ring1.OuterRadius + ring2.OuterRadius) { return true; }
            return false;
        }
    }
}
