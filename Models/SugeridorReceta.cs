namespace EjemploMVC4C.Models;

public class SugeridorReceta
{

    public string Nombre { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string TipoComida { get; set; }
    public decimal Presupuesto { get; set; }
    public int CantidadPersonas { get; set; }





    public int CalcularEdad()
    {
        int edad = DateTime.Today.Year - FechaNacimiento.Year;
        // Ajuste: si todavía no llegó su cumpleaños este año, resta 1
        if (FechaNacimiento.Date > DateTime.Today.AddYears(-edad))
            edad--;
        return edad;
    }


    public string DeterminarPlato()
    {
        if (TipoComida == "Caliente")
        {
            if (Presupuesto < 3000)       return "Fideos con manteca";
            else if (Presupuesto <= 7000) return "Arroz con verduras salteadas";
            else                          return "Pollo al horno con guarnición";
        }
        else // Fría
        {
            if (Presupuesto < 3000)       return "Ensalada simple";
            else if (Presupuesto <= 7000) return "Ensalada completa con proteína";
            else                          return "Tabla de fiambres y quesos";
        }
    }


    public int CalcularTiempo()
    {
        if (TipoComida == "Caliente")
        {
            if (CantidadPersonas <= 3)      return 20;
            else if (CantidadPersonas <= 7) return 40;
            else                            return 80;
        }
        else 
        {
            if (CantidadPersonas <= 3)      return 10;
            else if (CantidadPersonas <= 7) return 20;
            else                            return 40;
        }
    }


    public string DeterminarDificultad()
    {

        if (CantidadPersonas >= 8) return "Avanzado";

        if (Presupuesto < 3000 && CantidadPersonas <= 3) return "Principiante";

        return "Intermedio";
    }

}