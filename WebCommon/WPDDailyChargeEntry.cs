using System;

namespace WebCommon
{
	public class WPDDailyChargeEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.chargeDia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.chargeDia = reader.ReadInt32();
		}

		public WPDDailyChargeEntry()
		{
		}

		public int entryId;

		public int chargeDia;
	}
}
