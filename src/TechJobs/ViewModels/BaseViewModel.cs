﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobs.Models;


namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {
        // All columns, for display
        public List<JobFieldType> Columns { get; set; }

        // View title
        public string Title { get; set; } = "";
    }
}
