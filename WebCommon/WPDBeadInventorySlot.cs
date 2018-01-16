using System;

namespace WebCommon
{
	public class WPDBeadInventorySlot : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroBeadId);
			writer.Write(this.exp);
			writer.Write(this.level);
			writer.Write(this.beadId);
			writer.Write(this.beadRankId);
			writer.Write(this.slotNo);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroBeadId = reader.ReadString();
			this.exp = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.beadId = reader.ReadInt32();
			this.beadRankId = reader.ReadInt32();
			this.slotNo = reader.ReadInt32();
		}

		public WPDBeadInventorySlot()
		{
		}

		public string accountHeroBeadId;

		public int exp;

		public int level;

		public int beadId;

		public int beadRankId;

		public int slotNo;
	}
}
