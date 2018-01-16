using System;

namespace ClientCommon.PacketData
{
	public class PDSocket : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.no);
			writer.Write(this.itemId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.no = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
		}

		public PDSocket()
		{
		}

		public int no;

		public int itemId;
	}
}
