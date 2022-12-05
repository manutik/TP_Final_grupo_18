using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final
{
    public class cBarrio
    {
         public string nombre;
         public double x { get; set; }
         public double y { get; set; }

         public cBarrio(string _barrio, double _x, double _y)
         {
             this.nombre = _barrio;
             this.x = _x;
             this.y = _y;
         }
        /* public void inventamos()
       {
           cBarrio Comuna1 = new cBarrio("comuna 1",5,3);
           cBarrio Comuna2 = new cBarrio("comuna 2",4,4);
           cBarrio Comuna3 = new cBarrio("comuna 3",3,2);
           cBarrio Comuna4 = new cBarrio("comuna 4",4,1);
           cBarrio Comuna5 = new cBarrio("comuna 5",2,2);
           cBarrio Comuna6= new cBarrio("comuna 6",1,2);
           cBarrio Comuna7 = new cBarrio("comuna 7",0,1);
           cBarrio Comuna8 = new cBarrio("comuna 8",1,-1);
           cBarrio Comuna9 = new cBarrio("comuna 9", 0,0);//LINIERS
           cBarrio Comuna10 = new cBarrio("comuna 10",-3,1);
           cBarrio Comuna11 = new cBarrio("comuna 11",-2,3);
           cBarrio Comuna12 = new cBarrio("comuna 12",-3,5);
           cBarrio Comuna13 = new cBarrio("comuna 13",-1,6);
           cBarrio Comuna14 = new cBarrio("comuna 14",2,5);
           cBarrio Comuna15 = new cBarrio("comuna 15",0,4);
           cBarrio avellaneda = new cBarrio("avellaneda",5,0);
           cBarrio lanus = new cBarrio("lanus",3,-1);
           cBarrio lomas = new cBarrio("lomas de zamora",2,-2);
           cBarrio lamatanza = new cBarrio("la matanza",-1,-1);
           cBarrio moron = new cBarrio("comuna 1",-5,0);
           cBarrio tresdefeb = new cBarrio("tres de febrero",-4,3);
           cBarrio sanmartin = new cBarrio("san martin",-4,5);
           cBarrio vicentelopez = new cBarrio("vicente lopez",-4,6);
           cBarrio sanisidro = new cBarrio("san isidro",-5,6);

       }*/
    }
}
