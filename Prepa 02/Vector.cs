using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_02
{
    class Vector
    {
        Punto origen;
        Punto fin;
        double magnitud;


        public Vector()
        {
            origen = new Punto(0,0);
            fin = new Punto(1, 1);
            calcular_magnitud();
        }

        public Vector(Punto _origen, Punto _fin)
        {
            origen = new Punto(_origen.GetX(),_origen.GetY());
            fin = new Punto(_fin.GetX(), _fin.GetY());
            calcular_magnitud();
        }

        public Vector(float x_origen, float y_origen, float x_fin, float y_fin)
        {
            origen = new Punto(x_origen,y_origen);
            fin = new Punto(x_fin, y_fin);
            calcular_magnitud();
        }

        private void calcular_magnitud()
        {
            magnitud = Math.Sqrt(Math.Pow((fin.GetX() - origen.GetX()),2) + Math.Pow((fin.GetY() - origen.GetY()),2));
        }

        public double get_magnitud()
        {
            return magnitud;
        }

        private float productoPunto(Vector other)
        {
            return (origen.GetX() - fin.GetX()) * (other.origen.GetX() - other.fin.GetX()) + (origen.GetY() - fin.GetY()) + (other.origen.GetY() - other.fin.GetY());
        }
        
        public void set_origen(Punto _origen)
        {
            origen = new Punto(_origen.GetX(), _origen.GetY());
            calcular_magnitud();
        }

        public void set_origen(float x, float y)
        {
            origen = new Punto(x,y);
            calcular_magnitud();
        }

        public void set_fin(float x, float y)
        {
            fin = new Punto(x,y);
            calcular_magnitud();
        }

        public static Vector operator +(Vector sumando1, Vector sumando2)
        {
            Punto nuevo_origen = new Punto(sumando1.origen.GetX() + sumando2.origen.GetX(),
                                           sumando1.origen.GetY() + sumando2.origen.GetY());

            Punto nuevo_fin = new Punto(sumando1.fin.GetX() + sumando2.fin.GetX(),
                                        sumando1.fin.GetY() + sumando2.fin.GetY());

            return new Vector(nuevo_origen, nuevo_fin);
        }

        public static Vector operator -(Vector restando1, Vector restando2)
        {
            Punto nuevo_origen = new Punto(restando1.origen.GetX() - restando2.origen.GetX(),
                                           restando1.origen.GetY() - restando2.origen.GetY());

            Punto nuevo_fin = new Punto(restando1.fin.GetX() - restando2.fin.GetX(),
                                        restando1.fin.GetY() - restando2.fin.GetY());

            return new Vector(nuevo_origen, nuevo_fin);
        }

        public static Vector operator *(Vector multiplo1, float escalar)
        {
            Punto nuevo_origen = new Punto(multiplo1.origen.GetX() * escalar,
                                           multiplo1.origen.GetY() * escalar);

            Punto nuevo_fin = new Punto(multiplo1.fin.GetX() * escalar,
                                        multiplo1.fin.GetY() * escalar);

            return new Vector(nuevo_origen, nuevo_fin);
              
        }

        public static float operator *(Vector v1, Vector v2)
        {
            return v1.productoPunto(v2);
        }

        /* Pregunta de la actividad.
         
           Se puede acceder a ambos debido a que forman parte de la misma clase.
         */
    }
}
