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
            for (int i = 0; i < positions.Count(); i++)
            {
                if (p.Length() < positions[i].Length())
                {
                    positions.Insert(i, p);
                }
            }
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

            foreach (Position p in positions)
            {
                if (((p.X - centerPos.X) * (p.X - centerPos.X)) + ((p.Y - centerPos.Y) * (p.Y - centerPos.Y)) < (radius * radius))
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
            SortedPosList newList = sp1.Clone();

            foreach (Position p1 in sp1.positions)
            {
                foreach (Position p2 in sp2.positions)
                {
                    if (p1.Equals(p2))
                    {
                        newList.Remove(p1);
                    }
                }
            }

            return newList;
        }

        //public override string ToString()
        //{
        //    return positions.ToString();
        //}

        private void Save()
        {

        }

        private void Load()
        {

        }
    }
}
