using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Fruit
    {
        protected string color;
        protected string size;
        protected double weight;
        private string sweetness;

        public Fruit(string color,string size, double weight, string sweetness)
        {
            this.color = color;
            this.size = size;
            this.weight = weight;
            this.sweetness = sweetness;

        }

        public Fruit()
        {

        }

        public string Sweetness
        {
            get
            {
                return this.sweetness;   
            }
            set
            {
                this.sweetness = value;
            }
        }
    }
}
