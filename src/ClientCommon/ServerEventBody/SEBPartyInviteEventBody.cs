using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBPartyInviteEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.partyInstanceId);
			writer.Write(this.masterId);
			writer.Write(this.masterName);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.partyInstanceId = reader.ReadInt64();
			this.masterId = reader.ReadInt32();
			this.masterName = reader.ReadString();
		}

		public SEBPartyInviteEventBody()
		{
		}

		public long partyInstanceId;

		public int masterId;

		public string masterName;
	}
}
