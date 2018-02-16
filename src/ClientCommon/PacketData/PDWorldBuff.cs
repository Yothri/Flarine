using System;

namespace ClientCommon.PacketData
{
	public class PDWorldBuff : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.heroId);
			writer.Write(this.rate);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.heroId = reader.ReadInt32();
			this.rate = reader.ReadInt32();
		}

		public PDWorldBuff()
		{
		}

		public int heroId;

		public int rate;
	}
}
