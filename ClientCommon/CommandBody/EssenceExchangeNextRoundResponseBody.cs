using System;

namespace ClientCommon.CommandBody
{
	public class EssenceExchangeNextRoundResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.nextRound);
			writer.Write(this.unOwnGold);
			writer.Write(this.ownGold);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.nextRound = reader.ReadInt32();
			this.unOwnGold = reader.ReadInt64();
			this.ownGold = reader.ReadInt64();
		}

		public EssenceExchangeNextRoundResponseBody()
		{
		}

		public int nextRound;

		public long unOwnGold;

		public long ownGold;
	}
}
