using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBPartyMemberEnterEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.member);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.member = reader.ReadPDPacketData<PDPartyMember>();
		}

		public SEBPartyMemberEnterEventBody()
		{
		}

		public PDPartyMember member;
	}
}
