using System;

namespace WebCommon
{
	public class WPDAHExpDungeonDifficulty : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.expDungeonId);
			writer.Write(this.tradition);
			writer.Write(this.bestPlayTime);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.expDungeonId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.bestPlayTime = reader.ReadInt32();
		}

		public WPDAHExpDungeonDifficulty()
		{
		}

		public int expDungeonId;

		public int tradition;

		public int bestPlayTime;
	}
}
