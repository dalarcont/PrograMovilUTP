using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DA_Unidad2.Model
{
    public class ScoreRecords
    {
        [PrimaryKey]
        public string rs_akaEmail { get; set; }
        public int rs_score { get; set; }
    }
}
