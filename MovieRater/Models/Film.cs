using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class Film
    {
        public string title { get; set; }
        [Key]
        public int episode_id { get; set; }
        public string opening_crawl { get; set; }
        public string director { get; set; }
        public string producer { get; set; }
        public string release_date { get; set; }
        [NotMapped]
        public List<string> characters { get; set; }
        [NotMapped]
        public List<string> planets { get; set; }
        [NotMapped]
        public List<string> starships { get; set; }
        [NotMapped]
        public List<string> vehicles { get; set; }
        [NotMapped]
        public List<string> species { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; }
        public int numberOfVotes { get; set; }

        public float avg { get; set; }
    }
}
