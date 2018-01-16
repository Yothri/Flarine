using System;

namespace WebCommon
{
	public class WPDCostumeLevel : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.costumeId);
			writer.Write(this.level);
			writer.Write(this.materialItemCount);
			writer.Write(this.disassembleItemCount);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.costumeId = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.materialItemCount = reader.ReadInt32();
			this.disassembleItemCount = reader.ReadInt32();
		}

		public WPDCostumeLevel()
		{
		}

		public int costumeId;

		public int level;

		public int materialItemCount;

		public int disassembleItemCount;
	}
}
