using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBPartyInvitationRejectEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.accountHeroName);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.accountHeroName = reader.ReadString();
		}

		public SEBPartyInvitationRejectEventBody()
		{
		}

		public int accountHeroId;

		public string accountHeroName;
	}
}
