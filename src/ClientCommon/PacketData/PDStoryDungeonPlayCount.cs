using System;

namespace ClientCommon.PacketData
{
	public class PDStoryDungeonPlayCount : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storyDungeonId);
			writer.Write(this.count);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.storyDungeonId = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public PDStoryDungeonPlayCount()
		{
		}

		public int storyDungeonId;

		public int count;
	}
}
