using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circunferencia
{
    class circulo
    {
        private double _r; // _r -> Raio ;
        public double Raio { set => _r = value; get => _r; }
        public double Diametro => _r * 2;
        public double Area => Math.PI * _r * _r;
        public double Perímetro => 2 * Math.PI * _r;
    }
}
