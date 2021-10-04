using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class Liga1
    {
        public int MatchId { get; set; }
        public string TeamsName { get; set; }
        public DateTime Datat { get; set; }
        public int ScoreHome { get; set; }
        public int ScoreAway { get; set; }
        public decimal Moneys { get; set; }
    }
}
