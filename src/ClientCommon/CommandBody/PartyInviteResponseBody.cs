using System;

namespace ClientCommon.CommandBody
{
	public class PartyInviteResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.partyInstanceId);
			writer.Write(this.autoAccept);
			writer.Write(this.distributionType);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.partyInstanceId = reader.ReadInt64();
			this.autoAccept = reader.ReadBoolean();
			this.distributionType = reader.ReadInt32();
		}

		public PartyInviteResponseBody()
		{
		}

		public long partyInstanceId;

		public bool autoAccept;

		public int distributionType;
	}
}
