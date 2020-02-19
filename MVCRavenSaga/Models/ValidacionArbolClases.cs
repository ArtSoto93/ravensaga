using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCRavenSaga.Models
{
    [MetadataType(typeof(ArbolClasesMetaData))]
    public partial class ArbolClases
    {
        
    }
    public class ArbolClasesMetaData
    {
        
        [Display(Name = "ID de la Clase")]       
        public int IDClase { get; set; }

        [Required(ErrorMessage = "Clase Requedida")]
        [Display(Name = "Clase")]
        //[RegularExpression(@"^[A-Za-z]{3}-[0-9]{4}$", ErrorMessage = "El formato de la matrícula es XXX-0000")]
        public string Clase { get; set; }

        
        [Required(ErrorMessage = "HP Máximo Requerido")]
        [Display(Name = "HP Máximo")]
        [RegularExpression(@"^[0-9]{2}$", ErrorMessage = "Sólo se admiten 2 dígitos")]
        public int HPMax { get; set; }

        [Required(ErrorMessage = "Fuerza Máxima Requerida")]
        [Display(Name = "Fuerza Máxima")]
        [RegularExpression(@"^[0-9]{2}$", ErrorMessage = "Sólo se admiten 2 dígitos")]
        public int FuerzaMax { get; set; }

        [Required(ErrorMessage = "Magia Máxima Requerida")]
        [Display(Name = "Magia Máxima")]
        [RegularExpression(@"^[0-9]{2}$", ErrorMessage = "Sólo se admiten 2 dígitos")]
        public int MagiaMax { get; set; }

        [Required(ErrorMessage = "Habilidad Máxima Requerida")]
        [Display(Name = "Habilidad Máxima")]
        [RegularExpression(@"^[0-9]{2}$", ErrorMessage = "Sólo se admiten 2 dígitos")]
        public int HabMax { get; set; }

        [Required(ErrorMessage = "Velocidad Máxima Requerida")]
        [Display(Name = "Velocidad Máxima")]
        [RegularExpression(@"^[0-9]{2}$", ErrorMessage = "Sólo se admiten 2 dígitos")]
        public int VelMax { get; set; }

        [Required(ErrorMessage = "Suerte Máxima Requerida")]
        [Display(Name = "Suerte Máxima")]
        [RegularExpression(@"^[0-9]{2}$", ErrorMessage = "Sólo se admiten 2 dígitos")]
        public int SuerMax { get; set; }

        [Required(ErrorMessage = "Defensa Máxima Requerida")]
        [Display(Name = "Defensa Máxima")]
        [RegularExpression(@"^[0-9]{2}$", ErrorMessage = "Sólo se admiten 2 dígitos")]
        public int DefMax { get; set; }

        [Required(ErrorMessage = "Resistencia Máxima Requerida")]
        [Display(Name = "Resistencia Máxima")]
        [RegularExpression(@"^[0-9]{2}$", ErrorMessage = "Sólo se admiten 2 dígitos")]
        public int ResMax { get; set; }

        //[Display(Name = "Foto")]
        //public string URLFoto { get; set; }
    }
}