using System;

namespace ClientCommon.CommandBody
{
	public class GuildApplyAcceptCommandBody : CommandBody
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

		public GuildApplyAcceptCommandBody()
		{
		}

		public int accountHeroId;
	}
}
