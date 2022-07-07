using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunnettSquareGenerator
{
    internal class Frequencies
    {
        string genotype;
        public int number;
        public double percentage;
        Color color;
        public Frequencies(string g, int n, double p, Color c)
        {
            genotype = g;
            number = n;
            percentage = p;
            color = c;
        }
        public int Number
            { get { return number; } }
        public double Percentage
            { get { return percentage; } }
        public string Genotype
            { get { return genotype; } }
        public Color Color
            { get { return color; } }
    }
}