using System;

namespace ClientCommon.CommandBody
{
	public class GuildInviteByNameCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroName);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroName = reader.ReadString();
		}

		public GuildInviteByNameCommandBody()
		{
		}

		public string accountHeroName;
	}
}
