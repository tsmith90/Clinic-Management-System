﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSupport.Model
{
    /// <summary>
    /// Class the represents a LabTest
    /// </summary>
    class LabTests
    {
        public int PatientID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public int Code { get; set; }

        public DateTime DateTaken { get; set; }

        public DateTime DateReturned { get; set; }

        public string Result { get; set; }

        public int normal { get; set; }
    }
}
