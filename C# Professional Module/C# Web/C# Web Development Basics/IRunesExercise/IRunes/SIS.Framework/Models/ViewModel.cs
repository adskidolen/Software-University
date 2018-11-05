﻿namespace SIS.Framework.Models
{
    using System.Collections.Generic;

    public class ViewModel
    {
        public IDictionary<string, object> Data { get; set; }

        public ViewModel()
        {
            this.Data = new Dictionary<string, object>();
        }


        public object this[string key]
        {
            get => this.Data[key];
            set => this.Data[key] = value;
        }
    }
}