using System;

namespace WebCommon
{
	public class WPDGouthanMineMineral : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mineralId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.type);
			writer.Write(this.size);
			writer.Write(this.ownGold);
			writer.Write(this.magicPowder);
			writer.Write(this.ownDia);
			writer.Write(this.expFactor);
			writer.Write(this.miningDuration);
			writer.Write(this.regenDuration);
			writer.Write(this.miningRange);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.mineralId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.type = reader.ReadInt32();
			this.size = reader.ReadInt32();
			this.ownGold = reader.ReadInt32();
			this.magicPowder = reader.ReadInt32();
			this.ownDia = reader.ReadInt32();
			this.expFactor = reader.ReadDouble();
			this.miningDuration = reader.ReadInt32();
			this.regenDuration = reader.ReadInt32();
			this.miningRange = reader.ReadDouble();
		}

		public WPDGouthanMineMineral()
		{
		}

		public int mineralId;

		public string name;

		public string nameKey;

		public int type;

		public int size;

		public int ownGold;

		public int magicPowder;

		public int ownDia;

		public double expFactor;

		public int miningDuration;

		public int regenDuration;

		public double miningRange;
	}
}
