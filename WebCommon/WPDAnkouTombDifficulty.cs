using System;

namespace WebCommon
{
	public class WPDAnkouTombDifficulty : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tradition);
			writer.Write(this.recommendPower);
			writer.Write(this.exp);
			writer.Write(this.ownGold);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.tradition = reader.ReadInt32();
			this.recommendPower = reader.ReadInt32();
			this.exp = reader.ReadInt32();
			this.ownGold = reader.ReadInt32();
		}

		public WPDAnkouTombDifficulty()
		{
		}

		public int tradition;

		public int recommendPower;

		public int exp;

		public int ownGold;
	}
}
