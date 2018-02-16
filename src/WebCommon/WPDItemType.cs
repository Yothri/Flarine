using System;

namespace WebCommon
{
	public class WPDItemType : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.itemType);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.dailyUseMaxCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.itemType = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.dailyUseMaxCount = reader.ReadInt32();
		}

		public WPDItemType()
		{
		}

		public int itemType;

		public string name;

		public string nameKey;

		public int dailyUseMaxCount;
	}
}
