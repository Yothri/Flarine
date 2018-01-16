using System;

namespace WebCommon
{
	public class WPDMarbleRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.requiredGold);
			writer.Write(this.marblePieceId);
			writer.Write(this.marblePieceCount);
			writer.Write(this.questionPieceId);
			writer.Write(this.questionPieceCount);
			writer.Write(this.successRate);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.requiredGold = reader.ReadInt32();
			this.marblePieceId = reader.ReadInt32();
			this.marblePieceCount = reader.ReadInt32();
			this.questionPieceId = reader.ReadInt32();
			this.questionPieceCount = reader.ReadInt32();
			this.successRate = reader.ReadInt32();
		}

		public WPDMarbleRecipe()
		{
		}

		public int requiredGold;

		public int marblePieceId;

		public int marblePieceCount;

		public int questionPieceId;

		public int questionPieceCount;

		public int successRate;
	}
}
