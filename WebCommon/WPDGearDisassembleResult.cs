using System;

namespace WebCommon
{
	public class WPDGearDisassembleResult : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.grade);
			writer.Write(this.tier);
			writer.Write(this.acquireItemId);
			writer.Write(this.acquireRate);
			writer.Write(this.minAmount);
			writer.Write(this.maxAmount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.grade = reader.ReadInt32();
			this.tier = reader.ReadInt32();
			this.acquireItemId = reader.ReadInt32();
			this.acquireRate = reader.ReadInt32();
			this.minAmount = reader.ReadInt32();
			this.maxAmount = reader.ReadInt32();
		}

		public WPDGearDisassembleResult()
		{
		}

		public int grade;

		public int tier;

		public int acquireItemId;

		public int acquireRate;

		public int minAmount;

		public int maxAmount;
	}
}
