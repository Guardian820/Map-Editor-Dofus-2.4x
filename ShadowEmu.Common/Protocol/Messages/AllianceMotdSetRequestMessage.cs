


















// Generated on 01/12/2017 03:52:53
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class AllianceMotdSetRequestMessage : SocialNoticeSetRequestMessage
{

public const uint Id = 6687;
public uint MessageId
{
    get { return Id; }
}

public string content;
        

public AllianceMotdSetRequestMessage()
{
}

public AllianceMotdSetRequestMessage(string content)
        {
            this.content = content;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(content);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            content = reader.ReadUTF();
            

}


}


}