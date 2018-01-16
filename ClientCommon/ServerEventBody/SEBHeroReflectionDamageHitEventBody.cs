using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBHeroReflectionDamageHitEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.hp);
			writer.Write(this.damage);
			writer.Write(this.hpDamage);
			writer.Write(this.attacker);
			writer.Write(this.killer);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.hp = reader.ReadInt32();
			this.damage = reader.ReadInt32();
			this.hpDamage = reader.ReadInt32();
			this.attacker = reader.ReadPDAttacker<PDAttacker>();
			this.killer = reader.ReadPDKiller<PDKiller>();
		}

		public SEBHeroReflectionDamageHitEventBody()
		{
		}

		public int accountHeroId;

		public int hp;

		public int damage;

		public int hpDamage;

		public PDAttacker attacker;

		public PDKiller killer;
	}
}
