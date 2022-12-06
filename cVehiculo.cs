using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final
{
    public class cVehiculo   
    {
        protected string modelo;
        protected float anchoMax;
        protected float largoMax;
        protected float altoMax;
        public string PATENTE;
        public float contvolumen;
        public float contkilos;
        public float cantcombustible;
        public float kilos;
        public float volumen;
        public float combustible;
        public List<Pedido> entregas;


        public cVehiculo(string modelo, float anchoMax, float largoMax, float altoMax, string PATENTE, float Volumen, float Combustible, float kilos)
        {
            this.modelo = modelo;
            this.anchoMax = anchoMax;
            this.largoMax = largoMax;
            this.altoMax = altoMax;
            this.PATENTE = PATENTE;
            combustible = Combustible;
            volumen = Volumen;
            entregas = new List<Pedido>();
            this.kilos = kilos;
        }


        public void ordenarentregas()
        {
            
            entregas.Sort(delegate (Pedido x, Pedido y) { return x.dist_a_liniers.CompareTo(y.dist_a_liniers); });
            /*entregas.OrderByDescending<Pedido,Pedido dist_a_liniers>
            Pedido aux = entregas[0];
            for(int i = 0; i < entregas.Count; i++)
            {
               
            }*/
        }
       
    }
}
