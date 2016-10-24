using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace News_Focus
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INews" in both code and config file together.
    [ServiceContract]
    public interface INews
    {
        [OperationContract]
        string[] GetURL(string source);

    }
}
