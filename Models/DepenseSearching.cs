using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace appli_gest_assoc.Models
{
    public class DepenseSearching
    {
        public List<Depense> Depenses { get; set; }
        public SelectList TypeDepense { get; set; }
        public string BureauName { get; set; }
        public string SearchString { get; set; }
    }
}
