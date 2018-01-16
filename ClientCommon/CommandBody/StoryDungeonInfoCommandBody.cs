using System;

namespace ClientCommon.CommandBody
{
	public class StoryDungeonInfoCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storyDungeonId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.storyDungeonId = reader.ReadInt32();
		}

		public StoryDungeonInfoCommandBody()
		{
		}

		public int storyDungeonId;
	}
}
