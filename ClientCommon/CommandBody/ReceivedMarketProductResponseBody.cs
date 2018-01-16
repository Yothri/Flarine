using System;

namespace ClientCommon.CommandBody
{
	public class ReceivedMarketProductResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dia);
			writer.Write(this.gold);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.dia = reader.ReadInt32();
			this.gold = reader.ReadInt64();
		}

		public ReceivedMarketProductResponseBody()
		{
		}

		public int dia;

		public long gold;
	}
}
