using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class EnterPortalResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroes);
			writer.Write(this.monsters);
			writer.Write(this.dropObjects);
			writer.Write(this.arenaStatue);
			writer.Write(this.guildBattlefieldStatue);
			writer.Write(this.myAccountHero);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroes = reader.ReadPDPacketDatas<PDAccountHero>();
			this.monsters = reader.ReadPDMonsterInstances<PDMonsterInstance>();
			this.dropObjects = reader.ReadPDPacketDatas<PDDropObject>();
			this.arenaStatue = reader.ReadPDPacketData<PDArenaStatue>();
			this.guildBattlefieldStatue = reader.ReadPDPacketData<PDGuildBattlefieldStatue>();
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
		}

		public EnterPortalResponseBody()
		{
		}

		public PDAccountHero[] accountHeroes;

		public PDMonsterInstance[] monsters;

		public PDDropObject[] dropObjects;

		public PDArenaStatue arenaStatue;

		public PDGuildBattlefieldStatue guildBattlefieldStatue;

		public PDAccountHero myAccountHero;
	}
}
