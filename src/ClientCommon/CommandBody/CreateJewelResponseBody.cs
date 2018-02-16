﻿using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class CreateJewelResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ownGold);
			writer.Write(this.gold);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.ownGold = reader.ReadInt64();
			this.gold = reader.ReadInt64();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public CreateJewelResponseBody()
		{
		}

		public long ownGold;

		public long gold;

		public PDInventorySlot[] changedInventorySlots;
	}
}
