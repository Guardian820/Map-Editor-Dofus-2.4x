


















// Generated on 01/12/2017 03:52:54
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class AuthenticationTicketAcceptedMessage : NetworkMessage
{

public const uint Id = 111;
public uint MessageId
{
    get { return Id; }
}



public AuthenticationTicketAcceptedMessage()
{
}



public void Serialize(IDataWriter writer)
{



}

public void Deserialize(IDataReader reader)
{



}


}


}