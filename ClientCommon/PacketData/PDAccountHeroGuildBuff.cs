using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroGuildBuff : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.buffId);
			writer.Write(this.level);
			writer.Write(this.remainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.buffId = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.remainingTime = reader.ReadSingle();
		}

		public PDAccountHeroGuildBuff()
		{
		}

		public int buffId;

		public int level;

		public float remainingTime;
	}
}
