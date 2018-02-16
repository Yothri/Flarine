using System;

namespace ClientCommon.CommandBody
{
	public class GuildDungeonListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.currentDungeonId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.currentDungeonId = reader.ReadInt32();
		}

		public GuildDungeonListResponseBody()
		{
		}

		public int currentDungeonId;
	}
}
