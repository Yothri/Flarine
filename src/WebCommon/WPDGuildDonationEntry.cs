using System;

namespace WebCommon
{
	public class WPDGuildDonationEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.amount);
			writer.Write(this.dailyLimit);
			writer.Write(this.guildPoint);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.amount = reader.ReadInt32();
			this.dailyLimit = reader.ReadInt32();
			this.guildPoint = reader.ReadInt32();
		}

		public WPDGuildDonationEntry()
		{
		}

		public int entryId;

		public int amount;

		public int dailyLimit;

		public int guildPoint;
	}
}
