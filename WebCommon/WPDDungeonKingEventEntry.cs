using System;

namespace WebCommon
{
	public class WPDDungeonKingEventEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.requiredClearCount);
			writer.Write(this.itemId);
			writer.Write(this.itemCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.requiredClearCount = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.itemCount = reader.ReadInt32();
		}

		public WPDDungeonKingEventEntry()
		{
		}

		public int entryId;

		public int requiredClearCount;

		public int itemId;

		public int itemCount;
	}
}
