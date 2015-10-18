using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InstaceModeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PerCall" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class PerCall : IPerCall
    {
        private int call;
        public int PerCallIntance()
        {
            call += 1;
            return call;

        }
    }
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class PerSession : IPerSession
    {
        private int session;
        public int PerSessionInstance()
        {
            session += 1;
            return session;
        }
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class SingleCall : ISingleCall
    {
        private int single;
        public int SingleCallInstance()
        {
            single += 1;
            return single;
        }
    }
}
