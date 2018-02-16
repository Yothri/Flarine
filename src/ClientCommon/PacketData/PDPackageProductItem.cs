using System;

namespace ClientCommon.PacketData
{
	public class PDPackageProductItem : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.itemId);
			writer.Write(this.count);
			writer.Write(this.owned);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
			this.owned = reader.ReadBoolean();
		}

		public PDPackageProductItem()
		{
		}

		public int id;

		public int itemId;

		public int count;

		public bool owned;
	}
}
