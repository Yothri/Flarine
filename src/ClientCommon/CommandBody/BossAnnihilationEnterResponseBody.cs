using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class BossAnnihilationEnterResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.startRemainingTime);
			writer.Write(this.myAccountHero);
			writer.Write(this.accountHeroes);
			writer.Write(this.monsters);
			writer.Write(this.monsterDamages);
			writer.Write(this.monsterPartyDamages);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.startRemainingTime = reader.ReadInt32();
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.accountHeroes = reader.ReadPDPacketDatas<PDAccountHero>();
			this.monsters = reader.ReadPDMonsterInstances<PDMonsterInstance>();
			this.monsterDamages = reader.ReadPDPacketDatas<PDMonsterDamage>();
			this.monsterPartyDamages = reader.ReadPDPacketDatas<PDBossAnnihilationMonsterPartyDamage>();
		}

		public BossAnnihilationEnterResponseBody()
		{
		}

		public int startRemainingTime;

		public PDAccountHero myAccountHero;

		public PDAccountHero[] accountHeroes;

		public PDMonsterInstance[] monsters;

		public PDMonsterDamage[] monsterDamages;

		public PDBossAnnihilationMonsterPartyDamage[] monsterPartyDamages;
	}
}
