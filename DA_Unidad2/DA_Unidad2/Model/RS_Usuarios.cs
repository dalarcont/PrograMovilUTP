using System;
using System.Collections.Generic;
using System.Text;
using DA_Unidad2.ViewModel;
using SQLite;

namespace DA_Unidad2.Model
{
    public class RS_Usuarios
    {
        [PrimaryKey]
        public string rs_akaEmail { get; set; }
        public string rs_name { get; set; }
        public string rs_akaCenterId { get; set; }
        public string rs_akaCenterName { get; set; }
        public string rs_pkey { get; set; }
    }
}
