using System;

namespace ClientCommon.PacketData
{
	public class PDItemReward : PDReward
	{
		public override int type
		{
			get
			{
				return 2;
			}
		}

		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.itemId);
			writer.Write(this.count);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public PDItemReward()
		{
		}

		public int itemId;

		public int count;
	}
}
