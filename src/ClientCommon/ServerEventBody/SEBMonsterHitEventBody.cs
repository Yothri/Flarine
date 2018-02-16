using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBMonsterHitEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterInstanceId);
			writer.Write(this.maxHP);
			writer.Write(this.hp);
			writer.Write(this.moveSpeed);
			writer.Write(this.hitResult);
			writer.Write(this.killer);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterInstanceId = reader.ReadInt64();
			this.maxHP = reader.ReadInt32();
			this.hp = reader.ReadInt32();
			this.moveSpeed = reader.ReadSingle();
			this.hitResult = reader.ReadPDPacketData<PDHitResult>();
			this.killer = reader.ReadPDKiller<PDHeroKiller>();
		}

		public SEBMonsterHitEventBody()
		{
		}

		public long monsterInstanceId;

		public int maxHP;

		public int hp;

		public float moveSpeed;

		public PDHitResult hitResult;

		public PDHeroKiller killer;
	}
}
