using System;

namespace WebCommon
{
	public class WPDGoldDungeonDifficulty : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.goldDungeonId);
			writer.Write(this.tradition);
			writer.Write(this.recommandPower);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.goldDungeonId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.recommandPower = reader.ReadInt32();
		}

		public WPDGoldDungeonDifficulty()
		{
		}

		public int goldDungeonId;

		public int tradition;

		public int recommandPower;
	}
}
