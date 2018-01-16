using System;

namespace WebCommon
{
	public class WPDShineOrichalcumRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.itemId);
			writer.Write(this.requiredGold);
			writer.Write(this.orichalcumId);
			writer.Write(this.orichalcumCount);
			writer.Write(this.moonstoneId);
			writer.Write(this.moonstoneCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.itemId = reader.ReadInt32();
			this.requiredGold = reader.ReadInt32();
			this.orichalcumId = reader.ReadInt32();
			this.orichalcumCount = reader.ReadInt32();
			this.moonstoneId = reader.ReadInt32();
			this.moonstoneCount = reader.ReadInt32();
		}

		public WPDShineOrichalcumRecipe()
		{
		}

		public int itemId;

		public int requiredGold;

		public int orichalcumId;

		public int orichalcumCount;

		public int moonstoneId;

		public int moonstoneCount;
	}
}
