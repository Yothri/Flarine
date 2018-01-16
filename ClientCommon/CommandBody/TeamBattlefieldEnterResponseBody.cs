using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class TeamBattlefieldEnterResponseBody : ResponseBody
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
			this.startRemainingTime = reader.ReadSingle();
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.accountHeroes = reader.ReadPDPacketDatas<PDAccountHero>();
		}

		public TeamBattlefieldEnterResponseBody()
		{
		}

		public float startRemainingTime;

		public PDAccountHero myAccountHero;

		public PDAccountHero[] accountHeroes;
	}
}
