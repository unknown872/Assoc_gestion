using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace appli_gest_assoc.Models
{
    public class TypeDepenseSearching
    {
        public List<TypeDepense> TypeDepenses { get; set; }
        public SelectList NomTypeDepense { get; set; }
        public string TypeDepenseName { get; set; }
        public string SearchString { get; set; }
    }
}
