using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class MailReceiveResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ownGold);
			writer.Write(this.owndia);
			writer.Write(this.dia);
			writer.Write(this.magicPowder);
			writer.Write(this.receiveMailIds);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.accountHeroGears);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.ownGold = reader.ReadInt64();
			this.owndia = reader.ReadInt32();
			this.dia = reader.ReadInt32();
			this.magicPowder = reader.ReadInt64();
			this.receiveMailIds = reader.ReadGuids();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.accountHeroGears = reader.ReadPDPacketDatas<PDAccountHeroGearEx>();
		}

		public MailReceiveResponseBody()
		{
		}

		public long ownGold;

		public int owndia;

		public int dia;

		public long magicPowder;

		public Guid[] receiveMailIds;

		public PDInventorySlot[] changedInventorySlots;

		public PDAccountHeroGearEx[] accountHeroGears;
	}
}
