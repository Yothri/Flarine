using System;

namespace ClientCommon.PacketData
{
	public class PDTradeInventoryItem : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.count);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public PDTradeInventoryItem()
		{
		}

		public int id;

		public int count;
	}
}
