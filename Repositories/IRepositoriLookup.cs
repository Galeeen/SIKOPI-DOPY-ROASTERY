using SIKOPI_DOPY_ROASTERY.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_ROASTERY.Repositories
{
    public interface IRepositoriLookup
    {
        List<Lookup> DapatkanJenisBean();        // bean_types
        List<Lookup> DapatkanMetodeProses();     // process_methods
        List<Lookup> DapatkanGrade();            // grades
        List<Lookup> DapatkanTingkatRoasting();  // roast_levels
    }
}
