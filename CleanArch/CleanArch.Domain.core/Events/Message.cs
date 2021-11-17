﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.core.Events
{
    public abstract class Message :IRequest<bool>
    {
        public string MessageType { get; protected set;  }

        public Message()
        {
            MessageType = GetType().Name;
        }
    }
}
