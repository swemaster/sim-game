﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5
{
    public interface IDeepCopyable<T>
    {
        T DeepCopy();
    }
}
