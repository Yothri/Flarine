using System;

namespace WebCommon
{
	public class WPDGrowthEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
		}

		public WPDGrowthEntry()
		{
		}

		public int entryId;

		public string description;

		public string descriptionKey;
	}
}
