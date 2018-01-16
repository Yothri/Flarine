using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroElixirBuff : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.itemId);
			writer.Write(this.remainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.itemId = reader.ReadInt32();
			this.remainingTime = reader.ReadSingle();
		}

		public PDAccountHeroElixirBuff()
		{
		}

		public int itemId;

		public float remainingTime;
	}
}
