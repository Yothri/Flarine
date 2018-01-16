using System;

namespace WebCommon
{
	public class WPDStoryDungeonAdditionalEnter : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.difficulty);
			writer.Write(this.turn);
			writer.Write(this.itemId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.difficulty = reader.ReadInt32();
			this.turn = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
		}

		public WPDStoryDungeonAdditionalEnter()
		{
		}

		public int difficulty;

		public int turn;

		public int itemId;
	}
}
