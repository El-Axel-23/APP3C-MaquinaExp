using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones.Cafeteria
{
    internal class BebidaAlcoholica : Bebida
    {
        private float cantAlcohol;
        private string conGluten;

        public float CantAlcohol
        {
            get { return cantAlcohol; }
            set { cantAlcohol = value; }
        }
        public string ConGluten
        {
            get { return conGluten; }
            set { conGluten = value; }
        }
        public BebidaAlcoholica(
            string _nombre,
            string _tamaño,
            float _precio,
            float _cantAlcohol,
            string _conGluten)
            : base(_nombre, _tamaño, _precio)
        {
            CantAlcohol = _cantAlcohol;
            ConGluten = _conGluten;
        }
        public override string Preparar()
        {
            return "Preparando bebida alcohólica: " + Nombre + " de tamaño " + Tamaño + " (" + CantAlcohol  + "% alcohol)";
        }
        public string Listar()
        {
            return "Un/a " + Nombre;
        }
    }
}