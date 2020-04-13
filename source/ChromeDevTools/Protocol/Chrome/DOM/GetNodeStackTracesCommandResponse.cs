using MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
    [CommandResponse(ProtocolName.DOM.GetNodeStackTraces)]
    [SupportedBy("Chrome")]
    class GetNodeStackTracesCommandResponse
    {
        public StackTrace creation { get; set; }
    }
}
