using System;

namespace WebCommon
{
	public class WPDHeroLevelDeadTipHighLevelEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.level);
			writer.Write(this.entryId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.level = reader.ReadInt32();
			this.entryId = reader.ReadInt32();
			this.value = reader.ReadInt32();
		}

		public WPDHeroLevelDeadTipHighLevelEntry()
		{
		}

		public int level;

		public int entryId;

		public int value;
	}
}
