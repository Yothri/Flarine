using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PartyInvitationAcceptResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.masterId);
			writer.Write(this.autoAccept);
			writer.Write(this.distributionType);
			writer.Write(this.members);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.masterId = reader.ReadInt32();
			this.autoAccept = reader.ReadBoolean();
			this.distributionType = reader.ReadInt32();
			this.members = reader.ReadPDPacketDatas<PDPartyMember>();
		}

		public PartyInvitationAcceptResponseBody()
		{
		}

		public int masterId;

		public bool autoAccept;

		public int distributionType;

		public PDPartyMember[] members;
	}
}
