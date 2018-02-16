using System;

namespace ClientCommon.CommandBody
{
	public class GuildDonationWaterOfLifeCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.count);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.count = reader.ReadInt32();
		}

		public GuildDonationWaterOfLifeCommandBody()
		{
		}

		public int count;
	}
}
