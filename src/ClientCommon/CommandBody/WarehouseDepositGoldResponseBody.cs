using System;

namespace ClientCommon.CommandBody
{
	public class WarehouseDepositGoldResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.warehouseGold);
			writer.Write(this.warehouseOwnGold);
			writer.Write(this.gold);
			writer.Write(this.ownGold);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.warehouseGold = reader.ReadInt64();
			this.warehouseOwnGold = reader.ReadInt64();
			this.gold = reader.ReadInt64();
			this.ownGold = reader.ReadInt64();
		}

		public WarehouseDepositGoldResponseBody()
		{
		}

		public long warehouseGold;

		public long warehouseOwnGold;

		public long gold;

		public long ownGold;
	}
}
