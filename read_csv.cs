using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Collections.Generic;
using tp_final.Properties;
using tp_final;

namespace csvfiles {
    public class _csv {

        public List<Pedido> read_csv() {
            using (var reader = new StreamReader(Resources.archivo))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture)) {

                List<Pedido> records = new List<Pedido>();

                csv.Read();
                csv.ReadHeader();
                while(csv.Read()) {

                    Pedido record = new Pedido {
                        producto = csv.GetField<string>("producto"),
                        precio = csv.GetField<float>("precio"),
                        ancho = csv.GetField<float>("ancho"),
                        largo = csv.GetField<float>("largo"),
                        alto = csv.GetField<float>("alto"),
                        prioridad = csv.GetField<string>("prioridad"),
                        barrio = csv.GetField<string>("barrio"),
                        fecha = new DateTime(csv.GetField<int>("fecha")),
                        asignado = false
                        
                    };
                    records.Add(record);
                }

                return records;
            }
        }
    }
};

// Esta clase es base para la lectura del archivo
// Puede ser editada en base a su TP
public class Pedido {
    public string? producto { get; set; }
    public float precio { get; set; }
    public float largo { get; set; }
    public float ancho { get; set; }
    public float alto { get; set; }
    public string? prioridad { get; set; }
    public string? barrio { get; set; }
    public DateTime fecha { get; set; }
    public int dia;
    public bool asignado;
    public bool lineablanca;
    public float vol;
    public cBarrio ebarrio=null;
    public float dist_a_liniers;
    public string tostringentregas()
    {
        string aux = producto + "  " + barrio + "  " + prioridad;
        return aux;
    }
    public float distancia(cBarrio desde, cBarrio hasta)
    {
        float dist = 0;
        if (desde != null && hasta != null)
        {
            dist = (float)Math.Sqrt((hasta.x - desde.x) * (hasta.x - desde.x) + (hasta.y - desde.y) * (hasta.y - desde.y));
        }
        return dist;
    }
    
}