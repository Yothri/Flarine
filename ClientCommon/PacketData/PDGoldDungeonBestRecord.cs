using System;

namespace ClientCommon.PacketData
{
	public class PDGoldDungeonBestRecord : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tradition);
			writer.Write(this.accountHeroId);
			writer.Write(this.name);
			writer.Write(this.bestPlayTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.tradition = reader.ReadInt32();
			this.accountHeroId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.bestPlayTime = reader.ReadInt32();
		}

		public PDGoldDungeonBestRecord()
		{
		}

		public int tradition;

		public int accountHeroId;

		public string name;

		public int bestPlayTime;
	}
}
