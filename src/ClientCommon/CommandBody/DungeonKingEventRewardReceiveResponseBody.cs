using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class DungeonKingEventRewardReceiveResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.changedInventorySlot);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.changedInventorySlot = reader.ReadPDPacketData<PDInventorySlot>();
		}

		public DungeonKingEventRewardReceiveResponseBody()
		{
		}

		public PDInventorySlot changedInventorySlot;
	}
}
