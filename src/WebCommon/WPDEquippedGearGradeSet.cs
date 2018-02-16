using System;

namespace WebCommon
{
	public class WPDEquippedGearGradeSet : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.setId);
			writer.Write(this.grade);
			writer.Write(this.count);
			writer.Write(this.blessed);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.setId = reader.ReadInt32();
			this.grade = reader.ReadInt32();
			this.count = reader.ReadInt32();
			this.blessed = reader.ReadBoolean();
		}

		public WPDEquippedGearGradeSet()
		{
		}

		public int setId;

		public int grade;

		public int count;

		public bool blessed;
	}
}
