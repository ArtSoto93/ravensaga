using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MVCRavenSaga.Models
{
    public enum EmptyList
    {

    }

    public enum ElemAffin
    {

    }

    public enum ArmasT
    {
        Espadas,
        Lanzas,
        Hachas,
        Arcos,
        Luz,
        Anima,
        Oscuridad,
        Baston
    }
    public static class EnumExtensions
    {
        public static string GetDescripcion(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            if (fieldInfo.CustomAttributes.Count() == 0)
            {
                return value.ToString();
            }
            else
            {
                var attribute = (DisplayAttribute)fieldInfo.GetCustomAttribute(typeof(DisplayAttribute));
                return attribute.Name;
            }
        }
    }
}