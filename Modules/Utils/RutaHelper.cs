using System;
using System.Collections.Generic;
using api.Models.Traffic;


namespace api.Utils{
    public class RutaHelper{

    private static readonly string[] Rutas = new[]
    {
        "PAM00 - RUTA 01", "PAM01 - RUTA 02", "PAM03 - RUTA 03", "PAM05 - RUTA 04", "PAM07 - RUTA 03", "PAM08 - RUTA 03"
    };

    private static readonly string[] Sucursales = new[]
    {
        "GLOBAL", "SCOTIA", "BANK1", "BANK2", "BANK3", "BANK4"
    };

    private static readonly string[] Direcciones = new[]
    {
        "calle 50", "via arg", "via espa", "san fco", "colon", "bella vista"
    };
    
    // public List<Ruta> RutaCharger() {
        
    //     List<Ruta> rutas = new List<Ruta>();
    //     Ruta newRutas = new Ruta();
    //     for(int i=0; i < 5; i++){
    //         var rng = new Random();
    //         newRutas.Nombre = Rutas[rng.Next(Rutas.Length)];
    //         newRutas.Codigo = rng.Next(0, 100) + " " + rng.Next(0, 100) + rng.Next(0, 100);
    //         newRutas.Cliente = Sucursales[rng.Next(Sucursales.Length)];
    //         newRutas.Direccion = Direcciones[rng.Next(Direcciones.Length)];
    //         newRutas.Accion = rng.Next(1, 3).ToString();
    //         newRutas.Hora = DateTime.Now;
    //         rutas.Add(newRutas);
    //     }
        
    //     return rutas;
    // }
}
}