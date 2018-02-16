using System;

namespace ClientCommon.PacketData
{
	public class PDBossAnnihilationMonsterPartyDamage : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.partyInstanceId);
			writer.Write(this.partyDamage);
			writer.Write(this.updateTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.partyInstanceId = reader.ReadInt64();
			this.partyDamage = reader.ReadInt32();
			this.updateTime = reader.ReadDateTime();
		}

		public PDBossAnnihilationMonsterPartyDamage()
		{
		}

		public long partyInstanceId;

		public int partyDamage;

		public DateTime updateTime;
	}
}
