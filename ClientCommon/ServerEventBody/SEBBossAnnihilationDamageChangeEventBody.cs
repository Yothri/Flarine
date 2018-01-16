using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBBossAnnihilationDamageChangeEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.currentBossMonsterHp);
			writer.Write(this.damage);
			writer.Write(this.updateTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.currentBossMonsterHp = reader.ReadInt32();
			this.damage = reader.ReadInt32();
			this.updateTime = reader.ReadDateTime();
		}

		public SEBBossAnnihilationDamageChangeEventBody()
		{
		}

		public int accountHeroId;

		public int currentBossMonsterHp;

		public int damage;

		public DateTime updateTime;
	}
}
