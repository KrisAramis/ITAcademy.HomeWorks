﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW06.Task2
{
    public class SortAlphabetLength : System.Collections.IComparer
    {
        public int Compare(Object x, Object y)
        {
            if (x.ToString().Length == y.ToString().Length)
                return string.Compare(x.ToString(), y.ToString());
            else if (x.ToString().Length > y.ToString().Length)
                return -1;
            else
                return 1;
        }
    }
}
