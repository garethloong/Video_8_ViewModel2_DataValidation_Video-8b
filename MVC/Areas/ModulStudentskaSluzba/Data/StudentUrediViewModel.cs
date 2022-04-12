using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.ModulStudentskaSluzba.Data
{
    public class StudentUrediViewModel
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojIndexa { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public int SmjerId { get; set; }
        public List<SelectListItem> smjeroviStavke { get; set; }
    }
}