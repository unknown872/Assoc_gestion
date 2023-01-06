using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace appli_gest_assoc.Models
{
    public class TypeRecetteSearching
    {
        public List<TypeRecette> TypeRecettes { get; set; }
        public SelectList NomTypeRecette { get; set; }
        public string TypeRecetteName { get; set; }
        public string SearchString { get; set; }
    }
}
