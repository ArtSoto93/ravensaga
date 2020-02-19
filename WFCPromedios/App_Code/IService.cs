using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    [OperationContract]
    List<Promedios> getPromediosEF(int Cuantos);
}

[DataContract]
public class Promedios
{
    [DataMember]
    public string Nombre { get; set; }
    [DataMember]
    public string Nivel { get; set; }
    [DataMember]
    public string Clase { get; set; }
    [DataMember]
    public string HP { get; set; }
    [DataMember]
    public string Fuerza { get; set; }
    [DataMember]
    public string Magia { get; set; }
    [DataMember]
    public string Habilidad { get; set; }
    [DataMember]
    public string Velocidad { get; set; }
    [DataMember]
    public string Suerte { get; set; }
    [DataMember]
    public string Defensa { get; set; }
    [DataMember]
    public string Resistencia { get; set; }
    [DataMember]
    public string HPMax { get; set; }
    [DataMember]
    public string FuerzaMax { get; set; }
    [DataMember]
    public string MagiaMax { get; set; }
    [DataMember]
    public string HabMax { get; set; }
    [DataMember]
    public string VelMax { get; set; }
    [DataMember]
    public string SueMax { get; set; }
    [DataMember]
    public string DefMax { get; set; }
    [DataMember]
    public string ResMax { get; set; }
}

