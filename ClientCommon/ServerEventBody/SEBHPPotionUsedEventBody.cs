using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBHPPotionUsedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.hp);
			writer.Write(this.restoredHP);
			writer.Write(this.changedInventorySlot);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.hp = reader.ReadInt32();
			this.restoredHP = reader.ReadInt32();
			this.changedInventorySlot = reader.ReadPDPacketData<PDInventorySlot>();
		}

		public SEBHPPotionUsedEventBody()
		{
		}

		public int hp;

		public int restoredHP;

		public PDInventorySlot changedInventorySlot;
	}
}
