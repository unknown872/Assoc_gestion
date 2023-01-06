using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace appli_gest_assoc.Models
{
    public class AssociationSearching
    {
        public List<Association> Associations { get; set; }
        public SelectList NomAssociation { get; set; }
        public string AssociationName { get; set; }
        public string SearchString { get; set; }
    }
}
