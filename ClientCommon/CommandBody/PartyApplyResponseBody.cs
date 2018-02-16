using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PartyApplyResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accepted);
			writer.Write(this.appId);
			writer.Write(this.instanceId);
			writer.Write(this.masterId);
			writer.Write(this.autoAccept);
			writer.Write(this.distributionType);
			writer.Write(this.members);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accepted = reader.ReadBoolean();
			this.appId = reader.ReadInt64();
			this.instanceId = reader.ReadInt64();
			this.masterId = reader.ReadInt32();
			this.autoAccept = reader.ReadBoolean();
			this.distributionType = reader.ReadInt32();
			this.members = reader.ReadPDPacketDatas<PDPartyMember>();
		}

		public PartyApplyResponseBody()
		{
		}

		public bool accepted;

		public long appId;

		public long instanceId;

		public int masterId;

		public bool autoAccept;

		public int distributionType;

		public PDPartyMember[] members;
	}
}
