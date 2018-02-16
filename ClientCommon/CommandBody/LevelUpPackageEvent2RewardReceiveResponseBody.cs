using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class LevelUpPackageEvent2RewardReceiveResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dia);
			writer.Write(this.ownDia);
			writer.Write(this.changedInventorySlots);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.dia = reader.ReadInt32();
			this.ownDia = reader.ReadInt32();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
		}

		public LevelUpPackageEvent2RewardReceiveResponseBody()
		{
		}

		public int dia;

		public int ownDia;

		public PDInventorySlot[] changedInventorySlots;
	}
}
