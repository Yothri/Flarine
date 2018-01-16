using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class TownRevivalResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroes);
			writer.Write(this.arenaStatue);
			writer.Write(this.guildBattlefieldStatue);
			writer.Write(this.myAccountHero);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroes = reader.ReadPDPacketDatas<PDAccountHero>();
			this.arenaStatue = reader.ReadPDPacketData<PDArenaStatue>();
			this.guildBattlefieldStatue = reader.ReadPDPacketData<PDGuildBattlefieldStatue>();
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
		}

		public TownRevivalResponseBody()
		{
		}

		public PDAccountHero[] accountHeroes;

		public PDArenaStatue arenaStatue;

		public PDGuildBattlefieldStatue guildBattlefieldStatue;

		public PDAccountHero myAccountHero;
	}
}
