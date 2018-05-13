using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas
{
    class ClaseBase
    {

        private string _producto;
        private string _alumno;
        private string _contacto;
        private string _vehiculo;
        private ClaseBase _siguiente;

        public string Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }
        public string Alumno
        {
            get { return _alumno; }
            set { _alumno = value; }
        }
        public string Contacto
        {
            get { return _contacto; }
            set { _contacto = value; }
        }
        public string Vehiculo
        {
            get { return _vehiculo; }
            set { _vehiculo = value; }
        }

        public ClaseBase Siguiente
        {
            get { return Siguiente; }
            set { _siguiente = value; }
        }
        public ClaseBase(string producto, string alumno, string contacto, string vehiculo)
        {
            _producto = producto;
            _alumno = alumno;
            _contacto = contacto;
            _vehiculo = vehiculo;
        }
        public override string ToString()
        {
            return "Info = " + _producto + ", " + _alumno +", "+ _contacto +", "+ _vehiculo;
        }
    }
}
