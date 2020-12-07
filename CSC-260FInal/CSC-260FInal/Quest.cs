using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC_260FInal
{
    class Quest
    {
        int count = 0;
        List<String> quest = new List<string>();
       
        public string next()
        {
            string get = quest[count];
            count++;
            return get;
        }
       

    }
}
