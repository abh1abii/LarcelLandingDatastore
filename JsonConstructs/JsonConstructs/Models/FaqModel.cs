﻿namespace JsonConstructs.Models
{
    public class FaqModel
    {
        public int ID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public MetaModel Meta { get; set; }
    }
}
