﻿namespace PetClinic.Dtos.Export
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlType("Procedure")]
    public class ProcedureDto
    {
        public string Passport { get; set; }
        public string OwnerNumber { get; set; }
        public string DateTime { get; set; }
        public List<AnimalAidDto> AnimalAids { get; set; }
        public decimal TotalPrice { get; set; }
    }
}