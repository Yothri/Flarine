using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBBossAnnihilationPartyDamageChangeEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.partyInstanceId);
			writer.Write(this.damage);
			writer.Write(this.updateTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.partyInstanceId = reader.ReadInt64();
			this.damage = reader.ReadInt32();
			this.updateTime = reader.ReadDateTime();
		}

		public SEBBossAnnihilationPartyDamageChangeEventBody()
		{
		}

		public long partyInstanceId;

		public int damage;

		public DateTime updateTime;
	}
}
