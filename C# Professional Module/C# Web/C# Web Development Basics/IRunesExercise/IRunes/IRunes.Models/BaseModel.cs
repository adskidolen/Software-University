﻿namespace IRunes.Models
{
    public abstract class BaseModel<TKeyIdentifier>
    {
        public TKeyIdentifier Id { get; set; }
    }
}