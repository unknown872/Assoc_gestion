using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace appli_gest_assoc.Models
{
    public class MemberSearching
    {
        public List<Membre> Members { get; set; }
        public SelectList NomMembre { get; set; }
        public string MemberName { get; set; }
        public string SearchString { get; set; }
    }
}
