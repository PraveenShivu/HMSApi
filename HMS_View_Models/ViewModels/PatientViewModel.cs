using HMS_View_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_View_Models.ViewModels
{
    public class PatientViewModel
    {
        public IList<PatientModel>? Patients { get; set; }
        public PatientModel Patient { get; set; }
    }
}
