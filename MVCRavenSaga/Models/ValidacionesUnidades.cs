using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCRavenSaga.Models
{
    [MetadataType(typeof(UnidadesMetaData))]
    public partial class Unidades
    {
        public EmptyList ListaVacia { get; set; }
        public ElemAffin ElemAfinity { get; set; }
        public bool Promotion { get; set; }
    }
    public class UnidadesMetaData
    {

        [Display(Name = "Nombre de la unidad")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Seleccione de la lista")]
        [Display(Name = "Clase Inicial")]
        public int IDClase { get; set; }

        [Required(ErrorMessage = "HP Inicial Requerido")]
        [Display(Name = "HP Inicial")]
        [RegularExpression(@"^\d{1,2}$", ErrorMessage = "Sólo se admiten hasta 2 dígitos")]
        public int HP { get; set; }

        [Required(ErrorMessage = "Fuerza Inicial Requerida")]
        [Display(Name = "Fuerza Inicial")]
        [RegularExpression(@"^\d{1,2}$", ErrorMessage = "Sólo se admiten hasta 2 dígitos")]
        public int Fuerza { get; set; }

        [Required(ErrorMessage = "Magia Inicial Requerida")]
        [Display(Name = "Magia Inicial")]
        [RegularExpression(@"^\d{1,2}$", ErrorMessage = "Sólo se admiten hasta 2 dígitos")]
        public int Magia { get; set; }

        [Required(ErrorMessage = "Habilidad Inicial Requerida")]
        [Display(Name = "Habilidad Inicial")]
        [RegularExpression(@"^\d{1,2}$", ErrorMessage = "Sólo se admiten hasta 2 dígitos")]
        public int Habilidad { get; set; }

        [Required(ErrorMessage = "Velocidad Inicial Requerida")]
        [Display(Name = "Velocidad Inicial")]
        [RegularExpression(@"^\d{1,2}$", ErrorMessage = "Sólo se admiten hasta 2 dígitos")]
        public int Velocidad { get; set; }

        [Required(ErrorMessage = "Suerte Inicial Requerida")]
        [Display(Name = "Suerte Inicial")]
        [RegularExpression(@"^\d{1,2}$", ErrorMessage = "Sólo se admiten hasta 2 dígitos")]
        public int Suerte { get; set; }

        [Required(ErrorMessage = "Defensa Inicial Requerida")]
        [Display(Name = "Defensa Inicial")]
        [RegularExpression(@"^\d{1,2}$", ErrorMessage = "Sólo se admiten hasta 2 dígitos")]
        public int Defensa { get; set; }

        [Required(ErrorMessage = "Resistencia Inicial Requerida")]
        [Display(Name = "Resistencia Inicial")]
        [RegularExpression(@"^\d{1,2}$", ErrorMessage = "Sólo se admiten hasta 2 dígitos")]
        public int Resistencia { get; set; }

        [Required(ErrorMessage = "Crecimiento Requerido")]
        [Display(Name = "Crecimiento")]
        [RegularExpression(@"^\d{1,3}$", ErrorMessage = "Sólo se admiten hasta 3 dígitos")]
        public int HPGr { get; set; }

        [Required(ErrorMessage = "Crecimiento Requerido")]
        [Display(Name = "Crecimiento")]
        [RegularExpression(@"^\d{1,3}$", ErrorMessage = "Sólo se admiten hasta 3 dígitos")]
        public int FueGr { get; set; }

        [Required(ErrorMessage = "Crecimiento Requerido")]
        [Display(Name = "Crecimiento")]
        [RegularExpression(@"^\d{1,3}$", ErrorMessage = "Sólo se admiten hasta 3 dígitos")]
        public int MagGr { get; set; }

        [Required(ErrorMessage = "Crecimiento Requerido")]
        [Display(Name = "Crecimiento")]
        [RegularExpression(@"^\d{1,3}$", ErrorMessage = "Sólo se admiten hasta 3 dígitos")]
        public int HabGr { get; set; }

        [Required(ErrorMessage = "Crecimiento Requerido")]
        [Display(Name = "Crecimiento")]
        [RegularExpression(@"^\d{1,3}$", ErrorMessage = "Sólo se admiten hasta 3 dígitos")]
        public int VelGr { get; set; }

        [Required(ErrorMessage = "Crecimiento Requerido")]
        [Display(Name = "Crecimiento")]
        [RegularExpression(@"^\d{1,3}$", ErrorMessage = "Sólo se admiten hasta 3 dígitos")]
        public int SuerGr { get; set; }

        [Required(ErrorMessage = "Crecimiento Requerido")]
        [Display(Name = "Crecimiento")]
        [RegularExpression(@"^\d{1,3}$", ErrorMessage = "Sólo se admiten hasta 3 dígitos")]
        public int DefGr { get; set; }

        [Required(ErrorMessage = "Crecimiento Requerido")]
        [Display(Name = "Crecimiento")]
        [RegularExpression(@"^\d{1,3}$", ErrorMessage = "Sólo se admiten hasta 3 dígitos")]
        public int ResGr { get; set; }

        [Required(ErrorMessage = "Fecha de nacimiento Requerido")]
        [Display(Name = "Fecha de Nacimiento")]
        //[RegularExpression(@"^[0-9]{1-3}$", ErrorMessage = "Sólo se admiten hasta 3 dígitos")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Crecimiento Requerido")]
        [Display(Name = "Afinidad Elemental")]
        //[RegularExpression(@"^[0-9]{3}$", ErrorMessage = "Sólo se admiten hasta 3 dígitos")]
        public int IDElemento { get; set; }

        //[Display(Name = "Foto")]
        //public string URLFoto { get; set; }
    }
}