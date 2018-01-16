using System;

namespace ClientCommon.PacketData
{
	public class PDGearDisassembleResultItem : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.itemId);
			writer.Write(this.owned);
			writer.Write(this.count);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.itemId = reader.ReadInt32();
			this.owned = reader.ReadBoolean();
			this.count = reader.ReadInt32();
		}

		public PDGearDisassembleResultItem()
		{
		}

		public int itemId;

		public bool owned;

		public int count;
	}
}
