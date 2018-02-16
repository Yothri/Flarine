using System;

namespace WebCommon
{
	public class WPDPattern : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.patternId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
			writer.Write(this.grade);
			writer.Write(this.lootingRange);
			writer.Write(this.duration);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.patternId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
			this.grade = reader.ReadInt32();
			this.lootingRange = reader.ReadDouble();
			this.duration = reader.ReadInt32();
		}

		public WPDPattern()
		{
		}

		public int patternId;

		public string name;

		public string nameKey;

		public string description;

		public string descriptionKey;

		public int grade;

		public double lootingRange;

		public int duration;
	}
}
