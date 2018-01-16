using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBMonsterReflectionDamageHitEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterInstanceId);
			writer.Write(this.hp);
			writer.Write(this.damage);
			writer.Write(this.hpDamage);
			writer.Write(this.attacker);
			writer.Write(this.killer);
			writer.Write(this.time);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterInstanceId = reader.ReadInt64();
			this.hp = reader.ReadInt32();
			this.damage = reader.ReadInt32();
			this.hpDamage = reader.ReadInt32();
			this.attacker = reader.ReadPDAttacker<PDAttacker>();
			this.killer = reader.ReadPDKiller<PDHeroKiller>();
			this.time = reader.ReadDateTime();
		}

		public SEBMonsterReflectionDamageHitEventBody()
		{
		}

		public long monsterInstanceId;

		public int hp;

		public int damage;

		public int hpDamage;

		public PDAttacker attacker;

		public PDHeroKiller killer;

		public DateTime time;
	}
}
