using csvfiles;
namespace tp_final;

public enum DIA { dia1, dia2, dia3};
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        var csv_ = new csvfiles._csv();
        List<Pedido> Pedidos = csv_.read_csv();
        //creamos los barrios
        cBarrio Comuna1 = new cBarrio("comuna 1", 5, 3);
        cBarrio Comuna2 = new cBarrio("comuna 2", 4, 4);
        cBarrio Comuna3 = new cBarrio("comuna 3", 3, 2);
        cBarrio Comuna4 = new cBarrio("comuna 4", 4, 1);
        cBarrio Comuna5 = new cBarrio("comuna 5", 2, 2);
        cBarrio Comuna6 = new cBarrio("comuna 6", 1, 2);
        cBarrio Comuna7 = new cBarrio("comuna 7", 0, 1);
        cBarrio Comuna8 = new cBarrio("comuna 8", 1, -1);
        cBarrio Comuna9 = new cBarrio("comuna 9", 0, 0);//LINIERS
        cBarrio Comuna10 = new cBarrio("comuna 10", -3, 1);
        cBarrio Comuna11 = new cBarrio("comuna 11", -2, 3);
        cBarrio Comuna12 = new cBarrio("comuna 12", -3, 5);
        cBarrio Comuna13 = new cBarrio("comuna 13", -1, 6);
        cBarrio Comuna14 = new cBarrio("comuna 14", 2, 5);
        cBarrio Comuna15 = new cBarrio("comuna 15", 0, 4);
        cBarrio avellaneda = new cBarrio("avellaneda", 5, 0);
        cBarrio lanus = new cBarrio("lanus", 3, -1);
        cBarrio lomas = new cBarrio("lomas de zamora", 2, -2);
        cBarrio lamatanza = new cBarrio("la matanza", -1, -1);
        cBarrio moron = new cBarrio("comuna 1", -5, 0);
        cBarrio tresdefeb = new cBarrio("tres de febrero", -4, 3);
        cBarrio sanmartin = new cBarrio("san martin", -4, 5);
        cBarrio vicentelopez = new cBarrio("vicente lopez", -4, 6);
        cBarrio sanisidro = new cBarrio("san isidro", -5, 6);
        ponerbarrio();
        ponerdia();
        ponerlinea();
        ponervol();
        cVehiculo camion = new cVehiculo("Iveco Daily", (float)2.61, (float)5.12, 2, "KGF 251", (float)10800, (float)8.9, 7000);
        cVehiculo furgoneta = new cVehiculo("Fiat ducato", (float)2.61, (float)5.12, 2, "KGF 251", (float)17000, (float)8.9, 7000);
        cVehiculo kangoo = new cVehiculo("renault kangoo", (float)2.61, (float)5.12, 2, "KGF 251", (float)10.8, (float)8.9, 7000);







        // FUNCIONES
        void ponerbarrio()
        {
            for(int i = 0; i < Pedidos.Count; i++)
            {
                if (Pedidos[i] != null)
                {
                    if (Pedidos[i].barrio == "comuna 1")
                    {
                        Pedidos[i].ebarrio = Comuna1;
                    }
                    if (Pedidos[i].barrio == "comuna 2")
                    {
                        Pedidos[i].ebarrio = Comuna2;
                    }
                    if (Pedidos[i].barrio == "comuna 3")
                    {
                        Pedidos[i].ebarrio = Comuna3;
                    }
                    if (Pedidos[i].barrio == "comuna 4")
                    {
                        Pedidos[i].ebarrio = Comuna4;
                    }
                    if (Pedidos[i].barrio == "comuna 5")
                    {
                        Pedidos[i].ebarrio = Comuna5;
                    }
                    if (Pedidos[i].barrio == "comuna 6")
                    {
                        Pedidos[i].ebarrio = Comuna6;
                    }
                    if (Pedidos[i].barrio == "comuna 7")
                    {
                        Pedidos[i].ebarrio = Comuna7;
                    }
                    if (Pedidos[i].barrio == "comuna 8")
                    {
                        Pedidos[i].ebarrio = Comuna8;
                    }
                    if (Pedidos[i].barrio == "comuna 9")
                    {
                        Pedidos[i].ebarrio = Comuna9;
                    }
                    if (Pedidos[i].barrio == "comuna 10")
                    {
                        Pedidos[i].ebarrio = Comuna10;
                    }
                    if (Pedidos[i].barrio == "comuna 11")
                    {
                        Pedidos[i].ebarrio = Comuna11;
                    }
                    if (Pedidos[i].barrio == "comuna 12")
                    {
                        Pedidos[i].ebarrio = Comuna12;
                    }
                    if (Pedidos[i].barrio == "comuna 13")
                    {
                        Pedidos[i].ebarrio = Comuna13;
                    }
                    if (Pedidos[i].barrio == "comuna 14")
                    {
                        Pedidos[i].ebarrio = Comuna14;
                    }
                    if (Pedidos[i].barrio == "comuna 15")
                    {
                        Pedidos[i].ebarrio = Comuna15;
                    }
                    if (Pedidos[i].barrio == "avellaneda")
                    {
                        Pedidos[i].ebarrio = avellaneda;
                    }
                    if (Pedidos[i].barrio == "lomas de zamora")
                    {
                        Pedidos[i].ebarrio = lomas;
                    }
                    if (Pedidos[i].barrio == "lanus")
                    {
                        Pedidos[i].ebarrio = lanus;
                    }
                    if (Pedidos[i].barrio == "la matanza")
                    {
                        Pedidos[i].ebarrio = lamatanza;
                    }
                    if (Pedidos[i].barrio == "san martin")
                    {
                        Pedidos[i].ebarrio = sanmartin;
                    }
                    if (Pedidos[i].barrio == "san isidro")
                    {
                        Pedidos[i].ebarrio = sanisidro;
                    }
                    if (Pedidos[i].barrio == "tres de febrero")
                    {
                        Pedidos[i].ebarrio = tresdefeb;
                    }
                    if (Pedidos[i].barrio == "moron")
                    {
                        Pedidos[i].ebarrio = moron;
                    }
                    if (Pedidos[i].barrio == "vicente lopez")
                    {
                        Pedidos[i].ebarrio = vicentelopez;
                    }
                }
            }
        }
        void ponerdia()//les asignamos el numero del dia que sarpa la entrega segun prioridad
        {
            for (int i = 0; i < Pedidos.Count; i++)
            {
                if (Pedidos[i] != null)
                {
                    if (Pedidos[i].prioridad == "express")
                    {
                        Pedidos[i].dia = 1;
                    }
                    if (Pedidos[i].prioridad == "normal")
                    {
                        Pedidos[i].dia = 2;
                    }
                    if (Pedidos[i].prioridad == "diferido")
                    {
                        Pedidos[i].dia = 3;
                    }
                }
            }

        }
        void ponerlinea()
        {
            for (int i = 0; i < Pedidos.Count; i++)
            {
                if (Pedidos[i] != null)
                {
                    if (Pedidos[i].producto == "cocina" || Pedidos[i].producto == "calefon" || Pedidos[i].producto == "lavarropas" || Pedidos[i].producto == "heladera" || Pedidos[i].producto == "microondas" || Pedidos[i].producto == "freezer")
                    {
                        Pedidos[i].lineablanca = true;
                    }
                    else
                    {
                        Pedidos[i].lineablanca = false;
                    }
                }
            }

        }
        void ponervol()
        {
            for (int i = 0; i < Pedidos.Count; i++)
            {
                if (Pedidos[i] != null)
                {
                    Pedidos[i].vol = Pedidos[i].largo * Pedidos[i].ancho * Pedidos[i].alto;
                }
            }
        }

        void cargarcamiones(int dia)
        {
            for (int i = 0; i < Pedidos.Count; i++)
            {
                if (Pedidos[i].dia == dia && Pedidos[i].asignado == false)
                {
                    if (Pedidos[i].lineablanca == true && Pedidos[i].asignado != true)
                    {
                        if (camion.contkilos < camion.kilos && camion.contvolumen < camion.volumen)
                        {
                            camion.entregas.Add(Pedidos[i]);
                            camion.contvolumen = camion.contvolumen + Pedidos[i].vol;
                            camion.contkilos = camion.contkilos + camion.kilos;
                        }
                        else if (furgoneta.contkilos<furgoneta.kilos && furgoneta.contvolumen<furgoneta.volumen)
                        {
                            furgoneta.entregas.Add(Pedidos[i]);
                            furgoneta.contvolumen = furgoneta.contvolumen + Pedidos[i].vol;
                            furgoneta.contkilos = furgoneta.contkilos + furgoneta.kilos;
                        }
                    }
                    else
                    {
                        
                    }
                }
            }

        }

        void cargarkangoo()
        {

        }

        void mandararepartir()
        {

        }

        /*void inventamos()
        {
            cBarrio Comuna1 = new cBarrio("comuna 1", 5, 3);
            cBarrio Comuna2 = new cBarrio("comuna 2", 4, 4);
            cBarrio Comuna3 = new cBarrio("comuna 3", 3, 2);
            cBarrio Comuna4 = new cBarrio("comuna 4", 4, 1);
            cBarrio Comuna5 = new cBarrio("comuna 5", 2, 2);
            cBarrio Comuna6 = new cBarrio("comuna 6", 1, 2);
            cBarrio Comuna7 = new cBarrio("comuna 7", 0, 1);
            cBarrio Comuna8 = new cBarrio("comuna 8", 1, -1);
            cBarrio Comuna9 = new cBarrio("comuna 9", 0, 0);//LINIERS
            cBarrio Comuna10 = new cBarrio("comuna 10", -3, 1);
            cBarrio Comuna11 = new cBarrio("comuna 11", -2, 3);
            cBarrio Comuna12 = new cBarrio("comuna 12", -3, 5);
            cBarrio Comuna13 = new cBarrio("comuna 13", -1, 6);
            cBarrio Comuna14 = new cBarrio("comuna 14", 2, 5);
            cBarrio Comuna15 = new cBarrio("comuna 15", 0, 4);
            cBarrio avellaneda = new cBarrio("avellaneda", 5, 0);
            cBarrio lanus = new cBarrio("lanus", 3, -1);
            cBarrio lomas = new cBarrio("lomas de zamora", 2, -2);
            cBarrio lamatanza = new cBarrio("la matanza", -1, -1);
            cBarrio moron = new cBarrio("comuna 1", -5, 0);
            cBarrio tresdefeb = new cBarrio("tres de febrero", -4, 3);
            cBarrio sanmartin = new cBarrio("san martin", -4, 5);
            cBarrio vicentelopez = new cBarrio("vicente lopez", -4, 6);
            cBarrio sanisidro = new cBarrio("san isidro", -5, 6);

        }*/
    }
}