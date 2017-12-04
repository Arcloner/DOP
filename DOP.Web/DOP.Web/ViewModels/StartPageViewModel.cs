using DOP.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOP.Web.ViewModels
{
    public class StartPageViewModel
    {
        public List<Department> Departments { get; set; }
        public List<Personnel> Personnel { get; set; }        
    }
}