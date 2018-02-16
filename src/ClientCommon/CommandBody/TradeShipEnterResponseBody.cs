using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class TradeShipEnterResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.startRemainingTime);
			writer.Write(this.myAccountHero);
			writer.Write(this.accountHeroes);
			writer.Write(this.monsters);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.startRemainingTime = reader.ReadInt32();
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.accountHeroes = reader.ReadPDPacketDatas<PDAccountHero>();
			this.monsters = reader.ReadPDMonsterInstances<PDMonsterInstance>();
		}

		public TradeShipEnterResponseBody()
		{
		}

		public DateTime date;

		public int startRemainingTime;

		public PDAccountHero myAccountHero;

		public PDAccountHero[] accountHeroes;

		public PDMonsterInstance[] monsters;
	}
}
