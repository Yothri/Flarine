using System;

namespace WebCommon
{
	public class WPDDeadTipLowLevelEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.minLevel);
			writer.Write(this.maxLevel);
			writer.Write(this.requiredMenuActivationNo);
			writer.Write(this.displaySeq);
			writer.Write(this.iconName);
			writer.Write(this.repeatCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.minLevel = reader.ReadInt32();
			this.maxLevel = reader.ReadInt32();
			this.requiredMenuActivationNo = reader.ReadInt32();
			this.displaySeq = reader.ReadInt32();
			this.iconName = reader.ReadString();
			this.repeatCount = reader.ReadInt32();
		}

		public WPDDeadTipLowLevelEntry()
		{
		}

		public int entryId;

		public string name;

		public string nameKey;

		public int minLevel;

		public int maxLevel;

		public int requiredMenuActivationNo;

		public int displaySeq;

		public string iconName;

		public int repeatCount;
	}
}
