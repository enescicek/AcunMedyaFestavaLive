using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaFestavaLive.Entities
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string Title { get; set; }
        public string Decription { get; set; }
        public string DateInterval { get; set; }
        public string Location { get; set; }
    }
}