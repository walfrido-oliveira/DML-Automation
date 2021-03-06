﻿using System;
using System.Collections.Generic;

namespace Walfrido.DML.Automation.Model
{
    interface IParamsUpdate : IParams
    {
        IConditions Conditions { get; set; }
        IColumns Columns { get; set; }
        List<Object> Values { get; set; }
    }
}
