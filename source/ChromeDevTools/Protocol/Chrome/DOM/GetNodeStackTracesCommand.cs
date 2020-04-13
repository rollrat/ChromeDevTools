using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
    [Command(ProtocolName.DOM.GetNodeStackTraces)]
    [SupportedBy("Chrome")]
    class GetNodeStackTracesCommand : ICommand<GetNodeStackTracesCommandResponse>
    {
        public int NodeId { get; set; }
    }
}
