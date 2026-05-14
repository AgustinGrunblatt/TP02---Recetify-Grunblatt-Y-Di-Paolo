namespace TP02_Recetify_GrunblattyDiPaolo.Models;

public class SugeridorReceta
{
    public string Nombre { get; set; }
    public dateTime Fecha { get; set; }
    public int Tipo { get; set; }
    public int Presupuesto { get; set; }
    public int Cantidad { get; set; }

    public SugeridorReceta(string nombre, dateTime fecha, int tipo, int presupuesto, int cantidad)
    {
        this.Nombre = nombre;
        this.Fecha = fecha;
        this.Tipo = tipo;
        this.Presupuesto = presupuesto;
        this.Cantidad = cantidad;
    }
    public SugeridorReceta()
    {

    }

    public int CalcularEdad()
    {
        int edad = dateTime.Today.year - Fecha.Year;
        return edad;
    }

    public string DeterminarPlato()
    {
        if (Tipo == 1)
        {

            if(Presupuesto > 0 && Presupuesto < 3000)
            {
                return "fideos con manteca";
            }
            if(Presupuesto >= 3000 && Presupuesto < 7000)
            {
                return "arroz con verduritas";
            }
            if(Presupuesto >= 7000)
            {
                return "Pollo al horno con guarniciones";
            }
        }
        else
        {
            if(Presupuesto > 0 && Presupuesto < 3000)
            {
                return "ensalada simple";
            }
            if(Presupuesto >= 3000 && Presupuesto < 7000)
            {
                return "ensalada completa con proteinas";
            }
            if(Presupuesto >= 7000)
            {
                return "sushi";
            }
        }
    }
    public int CalcularTiempo()
    {
        if (Tipo == 1)
        {
            if(Cantidad > 0 && Cantidad < 4)
            {
                return 20;
            }
            if(Cantidad > 3 && Cantidad < 8)
            {
                return 40;
            }
            if(Cantidad >= 8)
            {
                return 80;
            }
        }
        else
        {
            if(Cantidad > 0 && Cantidad < 4)
            {
                return 10;
            }
            if(Cantidad > 3 && Cantidad < 8)
            {
                return 20;
            }
            if(Cantidad >= 8)
            {
                return 40;
            }
        }
    }
    public string DeterminarDificultad()
    {
        if (Presupuesto > 0 && Presupuesto < 3000)
        {
            if(Cantidad > 0 && Cantidad < 4)
            {
                return "Principiante";
            }
            else if(Cantidad < 8 && Cantidad > 3){
                return "Intermedio"
            }
        }
        else if(Presupuesto >= 3000  && Presupuesto < 7000)
        {
            if(Cantidad > 0 && Cantidad < 4)
            {
                return "Intermedio";
            }
            if(Cantidad >= 4)
            {
                return "Intermedio";
            }
        }
        else if(Presupuesto >= 7000 && Cantidad < 8){
            return "Intermedio";
        }
        else{
            return "Avanzado";
        }
    }

    public string GenerarSaludo()
    {
        if ( DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 12)
        {
            return "Buenos Días"
        }
        if (DateTime.Now.Hour >= 12 && < 20)
        {
            return "Buenas Tardes"
        }
        else
        {
            return "Buenas Noches"
        }
    }

    public string GenerarTip()
    {
        int edad = CalcularEdad();
        if (edad < 18)
        {
            return "ESTIMADO MENOR, TENGA SEGURIDAD, QUE TE COMERA EL CUCO"
        }
        if ( edad >= 60)
        {
            return "TIENES UN MENSAJE: ERES EPESIAL"
        }
        else
        {
            return "NO TE RINDAS, SE MEJOR, AUNQUE SEA UNA PAGINA DE COMIDA"
        }
    }
}