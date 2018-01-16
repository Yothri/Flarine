using System;

namespace WebCommon
{
	public class WPDGearGrade : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearId);
			writer.Write(this.grade);
			writer.Write(this.maxSkillDegree);
			writer.Write(this.maxDurability);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.gearId = reader.ReadInt32();
			this.grade = reader.ReadInt32();
			this.maxSkillDegree = reader.ReadInt32();
			this.maxDurability = reader.ReadInt32();
		}

		public WPDGearGrade()
		{
		}

		public int gearId;

		public int grade;

		public int maxSkillDegree;

		public int maxDurability;
	}
}
