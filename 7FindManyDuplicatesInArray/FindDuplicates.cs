using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _7FindManyDuplicatesInArray
{
    class FindDuplicates
    {
        string[] str;
        Hashtable ht = new Hashtable();
        string results = "";
        int temp;

        public FindDuplicates(string p)
        {
            str = p.Split(',');

            for (int i = 0; i < str.Length; i++)
            {
                if (ht[Convert.ToInt32(str[i])]!=null)
                {

                    temp = Convert.ToInt32(ht[Convert.ToInt32(str[i])]);
                    temp++;
                    ht.Remove(Convert.ToInt32(str[i]));
                    ht.Add(Convert.ToInt32(str[i]), temp);
                }
                else
                {
                    ht.Add(Convert.ToInt32(str[i]), 1);
                }
            }
        }
        public string getDuplicates()
        {
            for (int i = 0; i <= ht.Count; i++)
            {
                if (Convert.ToInt32(ht[i]) >1)
                {
                    results += i.ToString()+ " showed up " + ht[i] + " times, ";
                }
            }
            return results;
        }
    }
}
