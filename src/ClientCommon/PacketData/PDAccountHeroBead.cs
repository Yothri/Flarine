using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroBead : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.slotNo);
			writer.Write(this.socketId);
			writer.Write(this.accountHeroBeadId);
			writer.Write(this.exp);
			writer.Write(this.beadId);
			writer.Write(this.beadRankId);
			writer.Write(this.beadLevel);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.slotNo = reader.ReadInt32();
			this.socketId = reader.ReadInt32();
			this.accountHeroBeadId = reader.ReadGuid();
			this.exp = reader.ReadInt32();
			this.beadId = reader.ReadInt32();
			this.beadRankId = reader.ReadInt32();
			this.beadLevel = reader.ReadInt32();
		}

		public PDAccountHeroBead()
		{
		}

		public int slotNo;

		public int socketId;

		public Guid accountHeroBeadId;

		public int exp;

		public int beadId;

		public int beadRankId;

		public int beadLevel;
	}
}
