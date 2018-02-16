using System;

namespace ClientCommon.CommandBody
{
	public class WarehouseWithdrawGoldCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.isOwnGold);
			writer.Write(this.count);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.isOwnGold = reader.ReadBoolean();
			this.count = reader.ReadInt64();
		}

		public WarehouseWithdrawGoldCommandBody()
		{
		}

		public bool isOwnGold;

		public long count;
	}
}
