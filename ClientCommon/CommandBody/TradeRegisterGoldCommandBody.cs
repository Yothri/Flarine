using System;

namespace ClientCommon.CommandBody
{
	public class TradeRegisterGoldCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gold);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.gold = reader.ReadInt64();
		}

		public TradeRegisterGoldCommandBody()
		{
		}

		public long gold;
	}
}
