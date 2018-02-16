using System;

namespace WebCommon
{
	public class WPDGearTranscendRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.grade);
			writer.Write(this.gold);
			writer.Write(this.shineOrichalcumId);
			writer.Write(this.shineOrichalcumCount);
			writer.Write(this.jewelId);
			writer.Write(this.jewelCount);
			writer.Write(this.successRate);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.grade = reader.ReadInt32();
			this.gold = reader.ReadInt32();
			this.shineOrichalcumId = reader.ReadInt32();
			this.shineOrichalcumCount = reader.ReadInt32();
			this.jewelId = reader.ReadInt32();
			this.jewelCount = reader.ReadInt32();
			this.successRate = reader.ReadInt32();
		}

		public WPDGearTranscendRecipe()
		{
		}

		public int grade;

		public int gold;

		public int shineOrichalcumId;

		public int shineOrichalcumCount;

		public int jewelId;

		public int jewelCount;

		public int successRate;
	}
}
