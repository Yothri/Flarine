using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PartySurroundingPartyListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.partyInsts);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.partyInsts = reader.ReadPDPacketDatas<PDPartyInstance>();
		}

		public PartySurroundingPartyListResponseBody()
		{
		}

		public PDPartyInstance[] partyInsts;
	}
}
