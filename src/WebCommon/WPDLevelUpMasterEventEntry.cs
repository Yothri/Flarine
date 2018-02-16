using System;

namespace WebCommon
{
	public class WPDLevelUpMasterEventEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.requiredHeroLevel);
			writer.Write(this.limitCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.requiredHeroLevel = reader.ReadInt32();
			this.limitCount = reader.ReadInt32();
		}

		public WPDLevelUpMasterEventEntry()
		{
		}

		public int entryId;

		public int requiredHeroLevel;

		public int limitCount;
	}
}
