using System;

namespace WebCommon
{
	public class WPDGearSkillDegreeStep : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearId);
			writer.Write(this.grade);
			writer.Write(this.step);
			writer.Write(this.requiredSkillDegree);
			writer.Write(this.offenseFactor);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.gearId = reader.ReadInt32();
			this.grade = reader.ReadInt32();
			this.step = reader.ReadInt32();
			this.requiredSkillDegree = reader.ReadInt32();
			this.offenseFactor = reader.ReadDouble();
		}

		public WPDGearSkillDegreeStep()
		{
		}

		public int gearId;

		public int grade;

		public int step;

		public int requiredSkillDegree;

		public double offenseFactor;
	}
}
