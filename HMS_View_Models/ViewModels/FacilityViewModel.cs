using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_View_Models.Models;

namespace HMS_View_Models.ViewModels
{
    public class FacilityViewModel
    {
        public FacilityModel? Facility { get; set; }
        public List<FacilityModel>? FacilityList { get; set; }
    }
}
