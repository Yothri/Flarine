using System;

namespace WebCommon
{
	public class WPDCardRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.itemId);
			writer.Write(this.requiredGold);
			writer.Write(this.runePieceId);
			writer.Write(this.count);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.itemId = reader.ReadInt32();
			this.requiredGold = reader.ReadInt32();
			this.runePieceId = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public WPDCardRecipe()
		{
		}

		public int itemId;

		public int requiredGold;

		public int runePieceId;

		public int count;
	}
}
