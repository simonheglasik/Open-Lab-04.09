using System;
using System.Collections.Generic;
using System.Text;

namespace OpenLab_04._09
{
    class Class1
    {
        public List<string> RemoveDups(List<string> a)
        {
            for (int o = 0; o < a.Count; o++)
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[o] == a[i] & o != i)
                    {
                        a.Remove(a[o]);
                    }
                }
            }
            return a;
        }
    }
}