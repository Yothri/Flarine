using System;

namespace WebCommon
{
	public class WPDCostumeType : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.type);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.grade);
			writer.Write(this.materialItemId);
			writer.Write(this.disassembleItemId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.type = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.grade = reader.ReadInt32();
			this.materialItemId = reader.ReadInt32();
			this.disassembleItemId = reader.ReadInt32();
		}

		public WPDCostumeType()
		{
		}

		public int type;

		public string name;

		public string nameKey;

		public int grade;

		public int materialItemId;

		public int disassembleItemId;
	}
}
