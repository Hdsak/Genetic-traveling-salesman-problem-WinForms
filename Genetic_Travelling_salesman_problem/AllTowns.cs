using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace Genetic_Travelling_salesman_problem
{
    class AllTowns : List<Town>
    {
        public void OpenTownList(string fileName)
        {
            DataSet townDataSet = new DataSet();

            try
            {
                this.Clear();
                townDataSet.ReadXml(fileName);
                DataRowCollection towns = townDataSet.Tables[0].Rows;
                foreach (DataRow town in towns)
                {
                    this.Add(new Town(Convert.ToInt32(town["X"]), Convert.ToInt32(town["Y"])));
                }

            }
            finally
            {
                townDataSet.Dispose();
            }
        }
        public void CalculateTownDistance(int numberOfNearTowns)
        {
            foreach (Town town in this)
            {
                town.Distances.Clear();

                for (int i = 0; i < Count; i++)
                {
                    town.Distances.Add(Math.Sqrt(Math.Pow((double)(town.Position.X - this[i].Position.X), 2D) +
                                       Math.Pow((double)(town.Position.Y - this[i].Position.Y), 2D)));
                }
            }

            foreach (Town town in this)
            {
                town.NearestTownDistance(numberOfNearTowns);
            }

        }

    }
}
