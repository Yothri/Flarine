using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class StoryDungeonPlayResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.myAccountHero);
			writer.Write(this.changedInventorySlot);
			writer.Write(this.monsters);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.myAccountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.changedInventorySlot = reader.ReadPDPacketData<PDInventorySlot>();
			this.monsters = reader.ReadPDMonsterInstances<PDStoryDungeonMonsterInstance>();
		}

		public StoryDungeonPlayResponseBody()
		{
		}

		public DateTime date;

		public PDAccountHero myAccountHero;

		public PDInventorySlot changedInventorySlot;

		public PDStoryDungeonMonsterInstance[] monsters;
	}
}
