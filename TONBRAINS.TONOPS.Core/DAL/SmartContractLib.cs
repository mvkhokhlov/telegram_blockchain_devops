﻿using System.ComponentModel.DataAnnotations;

namespace TONBRAINS.TONOPS.Core.DAL
{
    public class SmartContractLib
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Namespace { get; set; }
        public string Version { get; set; }
    }
}
