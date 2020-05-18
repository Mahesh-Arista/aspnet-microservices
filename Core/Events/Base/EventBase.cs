﻿using Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Events.Base
{
    public abstract class EventBase : RequestBase
    {
        public DateTime CreatedOn => DateTime.UtcNow;
        public string SubmittedBy { get; set; }
        public string IP { get; set; }
    }
}