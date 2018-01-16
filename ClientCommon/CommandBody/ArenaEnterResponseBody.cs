using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class ArenaEnterResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.startRemainingTime);
			writer.Write(this.myAccountHero);
			writer.Write(this.accountHeroes);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.startRemainingTime = reader.ReadInt32();
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.accountHeroes = reader.ReadPDPacketDatas<PDAccountHero>();
		}

		public ArenaEnterResponseBody()
		{
		}

		public int startRemainingTime;

		public PDAccountHero myAccountHero;

		public PDAccountHero[] accountHeroes;
	}
}
