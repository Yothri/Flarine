using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GoldDungeonPlayResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.myAccountHero);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
		}

		public GoldDungeonPlayResponseBody()
		{
		}

		public DateTime date;

		public PDAccountHero myAccountHero;
	}
}
