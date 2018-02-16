using System;

namespace WebCommon
{
	public class WPDGearGradeDisassembleResult : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearId);
			writer.Write(this.grade);
			writer.Write(this.magicPowder);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.gearId = reader.ReadInt32();
			this.grade = reader.ReadInt32();
			this.magicPowder = reader.ReadInt32();
		}

		public WPDGearGradeDisassembleResult()
		{
		}

		public int gearId;

		public int grade;

		public int magicPowder;
	}
}
