using System;

namespace ClientCommon.ClientEventBody
{
	public class CEBHeroAttackHitEventBody : CEBClientEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.attackerId);
			writer.Write(this.monsterInstanceId);
			writer.Write(this.accountHeroId);
			writer.Write(this.isAutoBattle);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.attackerId = reader.ReadInt32();
			this.monsterInstanceId = reader.ReadInt64();
			this.accountHeroId = reader.ReadInt32();
			this.isAutoBattle = reader.ReadBoolean();
		}

		public CEBHeroAttackHitEventBody()
		{
		}

		public int attackerId;

		public long monsterInstanceId;

		public int accountHeroId;

		public bool isAutoBattle;
	}
}
