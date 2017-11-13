﻿using System.Collections.Generic;

namespace App.Core.Base
{
    internal interface IRandomizer
    {
        int GetRandom(int maxValue);
        IList<T> GetRandomFromList<T>(IList<T> list, int count);
        T GetRandomFromList<T>(IList<T> list);
        bool CheckIsLucky(int percent);
    }
}
