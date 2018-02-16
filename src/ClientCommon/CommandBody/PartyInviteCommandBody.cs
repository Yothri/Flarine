using System;

namespace ClientCommon.CommandBody
{
	public class PartyInviteCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
		}

		public PartyInviteCommandBody()
		{
		}

		public int accountHeroId;
	}
}
