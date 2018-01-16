using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBPartyApplicationAcceptedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.partyInstanceId);
			writer.Write(this.masterId);
			writer.Write(this.autoAccept);
			writer.Write(this.distributionType);
			writer.Write(this.members);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.partyInstanceId = reader.ReadInt64();
			this.masterId = reader.ReadInt32();
			this.autoAccept = reader.ReadBoolean();
			this.distributionType = reader.ReadInt32();
			this.members = reader.ReadPDPacketDatas<PDPartyMember>();
		}

		public SEBPartyApplicationAcceptedEventBody()
		{
		}

		public long partyInstanceId;

		public int masterId;

		public bool autoAccept;

		public int distributionType;

		public PDPartyMember[] members;
	}
}
