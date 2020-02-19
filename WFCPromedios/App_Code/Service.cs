using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    GameDBEntities db = new GameDBEntities();
    private List<Promedios> ListPromedios;

    List<Promedios> IService.getPromediosEF(int cuantos)
    {
        var query2 =
            (from U in db.Unidades
             join Cl in db.ArbolClases on U.IDClase equals Cl.IDClase
             orderby U.Nivel descending
             select new
             {
                 Nombre = U.Nombre.ToString(),
                 Nivel = U.Nivel.ToString(),
                 HP = (U.HP + (20 - U.Nivel) * U.HPGr / 100).ToString(),
                 Fuerza = (U.Fuerza + (20-U.Nivel) * U.FueGr / 100).ToString(),
                 Magia = (U.Magia + (20-U.Nivel) * U.MagGr / 100).ToString(),
                 Hab = (U.Habilidad + (20-U.Nivel) * U.HabGr / 100).ToString(),
                 Vel = (U.Velocidad + (20-U.Nivel) * U.VelGr / 100).ToString(),
                 Suerte = (U.Suerte + (20-U.Nivel) * U.SuerGr / 100).ToString(),
                 Defensa = (U.Defensa + (20-U.Nivel) * U.DefGr / 100).ToString(),
                 Resistencia = (U.Resistencia + (20-U.Nivel) * U.ResGr / 100).ToString(),
             }).Take(cuantos).ToList();
        ListPromedios = query2.AsEnumerable().Select
            (r1 => new Promedios
            {
                Nombre = r1.Nombre,
                Nivel = r1.Nivel,
                HP = r1.HP,
                Fuerza = r1.Fuerza,
                Magia = r1.Magia,
                Habilidad = r1.Hab,
                Velocidad = r1.Vel,
                Suerte = r1.Suerte,
                Defensa = r1.Defensa,
                Resistencia = r1.Resistencia,
            }).ToList();
        return ListPromedios;
    }
}
