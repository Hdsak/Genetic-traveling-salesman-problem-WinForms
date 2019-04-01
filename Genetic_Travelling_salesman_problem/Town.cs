using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Genetic_Travelling_salesman_problem
{
    //Класс для каждого города
    class Town
    {
        //Свойство для позиции города на карте
        public Point Position { get; set; }
        public Town(int x, int y)
        {
            Position = new Point(x, y);
        }
        //Расстояние от этого города до любого другого
        private List<double> distances = new List<double>();
        //Свойство для поля расстояния
        public List<double> Distances { get; set; }
        //Ближайшие города
        private List<int> nearTown = new List<int>();
        //Свойство для поля ближайшие города
        public List<int> NearTown { get; set; }
        //Метод для нахождения ближайшего города
        public void NearestTownDistance(int nearTownCount)
        {
            double closestDistance;
            int nearestTown = 0;
            double[] way = new double[Distances.Count];
            Distances.CopyTo(way);
            if (nearTownCount > Distances.Count - 1)
            {
                nearTownCount = Distances.Count - 1;
            }
            nearTown.Clear();
            for (int i = 0; i < nearTownCount; i++)
            {
                closestDistance = Double.MaxValue;
                for (int townNum = 0; townNum < Distances.Count; townNum++)
                {
                    if (way[townNum] < nearestTown)
                    {
                        closestDistance = way[townNum];
                        nearestTown = townNum;
                    }
                    nearTown.Add(nearestTown);
                    way[nearestTown] = Double.MaxValue;
                }
            }
        }

    }
}
