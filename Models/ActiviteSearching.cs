using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace appli_gest_assoc.Models
{
    public class ActiviteSearching
    {
        public List<Activite> Activites { get; set; }
        public SelectList NomActivite { get; set; }
        public string ActiviteName { get; set; }
        public string SearchString { get; set; }
    }
}
