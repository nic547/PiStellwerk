﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PiStellwerk.Models
{
    public class Engine
    {
        public string Name { get; set; }
        public byte SpeedSteps { get; set; }
        public int TopSpeed { get; set; }

        public List<DccFunction> Functions { get; set; }
    }

    public class DccFunction
    {
        public DccFunction() { }
        public DccFunction(byte id, string name)
        {
            Id = id;
            Name = name;
        }
        public byte Id { get; set; }
        public string Name { get; set; }
    }

    public enum FunctionType : byte
    {
        Sound = 0,
        Light = 1,
        Physical = 2
    }

    public enum FunctionKind : byte
    {
        Momentary = 0,
        Continus = 1,

    }
}
