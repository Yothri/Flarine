using System;

namespace ClientCommon.CommandBody
{
	public class GuildDungeonEnterCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.instanceId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.instanceId = reader.ReadInt64();
		}

		public GuildDungeonEnterCommandBody()
		{
		}

		public long instanceId;
	}
}
