using System;

namespace ClientCommon.CommandBody
{
	public class LuckyBagEventRewardReceiveCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
		}

		public LuckyBagEventRewardReceiveCommandBody()
		{
		}

		public int entryId;
	}
}
