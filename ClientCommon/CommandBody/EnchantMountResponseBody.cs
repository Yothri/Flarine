using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class EnchantMountResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.level);
			writer.Write(this.levelExp);
			writer.Write(this.isJackpot);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.level = reader.ReadInt32();
			this.levelExp = reader.ReadInt32();
			this.isJackpot = reader.ReadBoolean();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public EnchantMountResponseBody()
		{
		}

		public int level;

		public int levelExp;

		public bool isJackpot;

		public PDInventorySlot[] changedInventorySlots;
	}
}
