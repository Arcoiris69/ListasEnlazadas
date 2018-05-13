using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas
{
    class Estructura
    {
        ClaseBase inicio = null;
        public void agregar(ClaseBase nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                //ClaseBase t = inicio;
                //while(t.Siguiente != null)
                //    t = t.Siguiente;
                //    t.Siguiente = nuevo

                agregar(nuevo, inicio);
            }
        }
        private void agregar(ClaseBase nuevo, ClaseBase quien)
        {
            if (quien.Siguiente != null)
                agregar(nuevo, quien.Siguiente);
            else
                quien.Siguiente = nuevo;
        }
        private void agregarInicio(ClaseBase nuevo)
        {
            ClaseBase t = null;
            t = inicio;
            nuevo.Siguiente = t;
            inicio = nuevo;
        }
        public void EliminarUltimo()
        {
            ClaseBase te = inicio;
            ClaseBase t = null;
            while (te.Siguiente != null)
            {
                t = te;
                te = te.Siguiente;
            }
            t.Siguiente = null;
        }
        public void eliminarPrimero()
        {
            inicio = inicio.Siguiente;
        }
        public string Listar()
        {
            string res = "";
            ClaseBase t = inicio;
            while (t != null)
            {
                res += t.ToString() + Environment.NewLine;
                t = t.Siguiente;
            }
            return res;
        }
        public void InvertirLista()
        {
            ClaseBase te = null;
            ClaseBase t = inicio;
            ClaseBase x;

            while (t != null)
            {
                x = t.Siguiente;
                t.Siguiente = te;
                te = t;
                t = x;
            }
            inicio = te;
        }
        public string ReporteInverso()
        {
            string res = "";
            ClaseBase temp = inicio;
            while (temp != null)
            {
                res = temp.ToString() + "\r\n" + res;
                temp = temp.Siguiente;
            }
            return res;
        }
    }
}
