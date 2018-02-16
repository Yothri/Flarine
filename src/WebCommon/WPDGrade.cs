using System;

namespace WebCommon
{
	public class WPDGrade : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.grade);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.maxGearAttrEnchantLevel);
			writer.Write(this.runeEnchantEnabled);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.grade = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.maxGearAttrEnchantLevel = reader.ReadInt32();
			this.runeEnchantEnabled = reader.ReadBoolean();
		}

		public WPDGrade()
		{
		}

		public int grade;

		public string name;

		public string nameKey;

		public int maxGearAttrEnchantLevel;

		public bool runeEnchantEnabled;
	}
}
