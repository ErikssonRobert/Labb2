using System;
using System.Collections.Generic;
using System.Linq;

namespace Labb2
{
    public class SortedPosList
    {
        private List<Position> positions;
        public List<Position> Positions { get; }

        public SortedPosList()
        {
            positions = new List<Position>();
        }

        public SortedPosList(string filePath)
        {
            positions = new List<Position>();
            //System.IO.File.WriteAllLines(@FILEPATH, positions.ToArray());
        }

        public int Count() => positions.Count;

        public void Add(Position p)
        {
            positions.Add(p);
            positions.Sort((p1, p2) => p1.Length().CompareTo(p2.Length()));
        }

        public bool Remove(Position p)
        {
            return positions.Remove(p) ? true : false;
        }

        public SortedPosList Clone()
        {
            SortedPosList newList = new SortedPosList();

            for (int i = 0; i < positions.Count(); i++)
            {
                newList.Add(positions[i].Clone());
            }
            return newList;
        }

        public SortedPosList CircleContent(Position centerPos, double radius)
        {
            SortedPosList newList = new SortedPosList();

            foreach (Position p in this.positions)
            {
                if ((Math.Pow(p.X - centerPos.X, 2) + Math.Pow(p.Y - centerPos.Y, 2)) < Math.Pow(radius, 2))
                {
                    newList.Add(p.Clone());
                }
            }

            return newList;
        }

        public static SortedPosList operator +(SortedPosList sp1, SortedPosList sp2)
        {
            SortedPosList newList = sp1.Clone();

            foreach (Position p in sp2.positions)
            {
                newList.Add(p);
            }

            return newList;
        }

        public static SortedPosList operator -(SortedPosList sp1, SortedPosList sp2)
        {
            foreach (Position p1 in sp1.positions.Reverse<Position>())
            {
                foreach (Position p2 in sp2.positions.Reverse<Position>())
                {
                    if (p1.Equals(p2))
                    {
                        sp1.Remove(p1);
                    }
                }
            }

            return sp1.Clone();
        }

        public override string ToString()
        {
            return string.Join(", ", positions);
        }

        private void Save()
        {

        }

        private void Load()
        {

        }
    }
}
