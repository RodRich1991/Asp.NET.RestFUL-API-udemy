﻿using System.Runtime.Serialization;

namespace RestWithAsp.NET_core.UDEMY.v1.Model.Base
{
    [DataContract]
    public class BaseEntity
    {
        public int Id { get; set; }
    }
}
