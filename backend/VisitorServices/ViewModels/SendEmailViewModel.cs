﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorServices.ViewModels
{
    public class SendEmailViewModel
    {
        public int EmployeeNumber { get; set; }
        public string mailsubject { get; set; }
        public string mailbody { get; set; }

        public int VisitorId { get; set; }

       
    }
}
