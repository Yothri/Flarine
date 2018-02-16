using System;

namespace WebCommon
{
	public class WPDGuildBuffLevel : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.buffId);
			writer.Write(this.level);
			writer.Write(this.requiredWaterOfLife);
			writer.Write(this.requiredUnOwnGold);
			writer.Write(this.duration);
			writer.Write(this.factor);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.buffId = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.requiredWaterOfLife = reader.ReadInt32();
			this.requiredUnOwnGold = reader.ReadInt32();
			this.duration = reader.ReadInt32();
			this.factor = reader.ReadDouble();
		}

		public WPDGuildBuffLevel()
		{
		}

		public int buffId;

		public int level;

		public int requiredWaterOfLife;

		public int requiredUnOwnGold;

		public int duration;

		public double factor;
	}
}
