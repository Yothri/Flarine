using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroGuildDonationCount : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.count);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public PDAccountHeroGuildDonationCount()
		{
		}

		public int entryId;

		public int count;
	}
}
