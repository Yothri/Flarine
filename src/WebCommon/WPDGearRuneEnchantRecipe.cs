using System;

namespace WebCommon
{
	public class WPDGearRuneEnchantRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tier);
			writer.Write(this.grade);
			writer.Write(this.gold);
			writer.Write(this.materialItemCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.tier = reader.ReadInt32();
			this.grade = reader.ReadInt32();
			this.gold = reader.ReadInt32();
			this.materialItemCount = reader.ReadInt32();
		}

		public WPDGearRuneEnchantRecipe()
		{
		}

		public int tier;

		public int grade;

		public int gold;

		public int materialItemCount;
	}
}
