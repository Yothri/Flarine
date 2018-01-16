using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class GuildDungeonEnterResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.myAccountHero);
			writer.Write(this.damage);
			writer.Write(this.accountHeroes);
			writer.Write(this.monsters);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.damage = reader.ReadInt32();
			this.accountHeroes = reader.ReadPDPacketDatas<PDAccountHero>();
			this.monsters = reader.ReadPDMonsterInstances<PDMonsterInstance>();
		}

		public GuildDungeonEnterResponseBody()
		{
		}

		public PDAccountHero myAccountHero;

		public int damage;

		public PDAccountHero[] accountHeroes;

		public PDMonsterInstance[] monsters;
	}
}
