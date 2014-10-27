using System;

namespace VirusTotalNET.Objects
{
    public class Samples
    {
        public DateTime Date { get; set; }
        public int Positives { get; set; }
        public int Total { get; set; }
        public string Sha256 { get; set; }
    }
}