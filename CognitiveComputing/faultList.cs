using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveComputing
{
    class faultList
    {
        private List<Fault> faultsArr = new List<Fault>();
        Fault currentFault;

        public void addFault(Fault fault)
        {
            faultsArr.Add(fault);
            currentFault = fault;
        }
    }
}
