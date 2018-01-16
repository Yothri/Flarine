using System;

namespace ClientCommon.PacketData
{
	public class PDStoryDungeonBestRecord : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storyDungeonId);
			writer.Write(this.difficulty);
			writer.Write(this.accountHeroId);
			writer.Write(this.name);
			writer.Write(this.bestPlayTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.storyDungeonId = reader.ReadInt32();
			this.difficulty = reader.ReadInt32();
			this.accountHeroId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.bestPlayTime = reader.ReadInt32();
		}

		public PDStoryDungeonBestRecord()
		{
		}

		public int storyDungeonId;

		public int difficulty;

		public int accountHeroId;

		public string name;

		public int bestPlayTime;
	}
}
