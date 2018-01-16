using System;

namespace ClientCommon.CommandBody
{
	public class GuildCreateCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.guildName);
			writer.Write(this.isAutoJoin);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.guildName = reader.ReadString();
			this.isAutoJoin = reader.ReadBoolean();
		}

		public GuildCreateCommandBody()
		{
		}

		public string guildName;

		public bool isAutoJoin;
	}
}
