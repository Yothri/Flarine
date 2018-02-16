using System;

namespace ClientCommon.PacketData
{
	public class PDBossAnnihilationBestRecord : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tradition);
			writer.Write(this.accountHeroId);
			writer.Write(this.name);
			writer.Write(this.damage);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.tradition = reader.ReadInt32();
			this.accountHeroId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.damage = reader.ReadInt32();
		}

		public PDBossAnnihilationBestRecord()
		{
		}

		public int tradition;

		public int accountHeroId;

		public string name;

		public int damage;
	}
}
