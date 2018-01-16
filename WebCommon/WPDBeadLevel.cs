using System;

namespace WebCommon
{
	public class WPDBeadLevel : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.beadId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.beadRankId);
			writer.Write(this.level);
			writer.Write(this.exp);
			writer.Write(this.grade);
			writer.Write(this.requiredExp);
			writer.Write(this.attrId);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.beadId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.beadRankId = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.exp = reader.ReadInt32();
			this.grade = reader.ReadInt32();
			this.requiredExp = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
		}

		public WPDBeadLevel()
		{
		}

		public int beadId;

		public string name;

		public string nameKey;

		public int beadRankId;

		public int level;

		public int exp;

		public int grade;

		public int requiredExp;

		public int attrId;

		public double value;
	}
}
