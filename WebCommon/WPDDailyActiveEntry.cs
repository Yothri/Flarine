using System;

namespace WebCommon
{
	public class WPDDailyActiveEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.objectType);
			writer.Write(this.objectValue);
			writer.Write(this.objectCount);
			writer.Write(this.activePoint);
			writer.Write(this.currentObjectCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.objectType = reader.ReadInt32();
			this.objectValue = reader.ReadInt32();
			this.objectCount = reader.ReadInt32();
			this.activePoint = reader.ReadInt32();
			this.currentObjectCount = reader.ReadInt32();
		}

		public WPDDailyActiveEntry()
		{
		}

		public int entryId;

		public string name;

		public string nameKey;

		public int objectType;

		public int objectValue;

		public int objectCount;

		public int activePoint;

		public int currentObjectCount;
	}
}
