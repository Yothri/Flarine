using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBHeroHitEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.maxHP);
			writer.Write(this.hp);
			writer.Write(this.moveSpeed);
			writer.Write(this.hitResult);
			writer.Write(this.killer);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.maxHP = reader.ReadInt32();
			this.hp = reader.ReadInt32();
			this.moveSpeed = reader.ReadSingle();
			this.hitResult = reader.ReadPDPacketData<PDHitResult>();
			this.killer = reader.ReadPDKiller<PDKiller>();
		}

		public SEBHeroHitEventBody()
		{
		}

		public int accountHeroId;

		public int maxHP;

		public int hp;

		public float moveSpeed;

		public PDHitResult hitResult;

		public PDKiller killer;
	}
}
