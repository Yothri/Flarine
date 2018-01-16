using System;

namespace ClientCommon.CommandBody
{
	public class StoryDungeonPlayCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storyDungeonId);
			writer.Write(this.difficulty);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.storyDungeonId = reader.ReadInt32();
			this.difficulty = reader.ReadInt32();
		}

		public StoryDungeonPlayCommandBody()
		{
		}

		public int storyDungeonId;

		public int difficulty;
	}
}
