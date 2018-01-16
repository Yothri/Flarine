using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class EvolveMountResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tier);
			writer.Write(this.tierExp);
			writer.Write(this.level);
			writer.Write(this.levelExp);
			writer.Write(this.isJackpot);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.tier = reader.ReadInt32();
			this.tierExp = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.levelExp = reader.ReadInt32();
			this.isJackpot = reader.ReadBoolean();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public EvolveMountResponseBody()
		{
		}

		public int tier;

		public int tierExp;

		public int level;

		public int levelExp;

		public bool isJackpot;

		public PDInventorySlot[] changedInventorySlots;
	}
}
