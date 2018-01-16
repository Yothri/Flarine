using System;

namespace ClientCommon.CommandBody
{
	public class GuildOwnBuffReceiveCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.buffId);
			writer.Write(this.level);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.buffId = reader.ReadInt32();
			this.level = reader.ReadInt32();
		}

		public GuildOwnBuffReceiveCommandBody()
		{
		}

		public int buffId;

		public int level;
	}
}
