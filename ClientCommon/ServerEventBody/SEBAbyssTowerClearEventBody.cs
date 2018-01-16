using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBAbyssTowerClearEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.hp);
			writer.Write(this.ownGold);
			writer.Write(this.starEssense);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.hp = reader.ReadInt32();
			this.ownGold = reader.ReadInt64();
			this.starEssense = reader.ReadInt64();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public SEBAbyssTowerClearEventBody()
		{
		}

		public int hp;

		public long ownGold;

		public long starEssense;

		public PDInventorySlot[] changedInventorySlots;
	}
}
