using System;

namespace ClientCommon.PacketData
{
	public class PDMainQuestReward : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mainQuestId);
			writer.Write(this.id);
			writer.Write(this.type);
			writer.Write(this.gearId);
			writer.Write(this.gearInstance);
			writer.Write(this.itemId);
			writer.Write(this.count);
			writer.Write(this.mountId);
			writer.Write(this.petId);
			writer.Write(this.petInstance);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.mainQuestId = reader.ReadInt32();
			this.id = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.gearId = reader.ReadInt32();
			this.gearInstance = reader.ReadPDPacketData<PDGearInstance>();
			this.itemId = reader.ReadInt32();
			this.count = reader.ReadInt32();
			this.mountId = reader.ReadInt32();
			this.petId = reader.ReadInt32();
			this.petInstance = reader.ReadPDPacketData<PDPetInstance>();
		}

		public PDMainQuestReward()
		{
		}

		public const int kType_Gear = 1;

		public const int kType_Item = 2;

		public const int kType_Mount = 3;

		public const int kType_Pet = 4;

		public int mainQuestId;

		public int id;

		public int type;

		public int gearId;

		public PDGearInstance gearInstance;

		public int itemId;

		public int count;

		public int mountId;

		public int petId;

		public PDPetInstance petInstance;
	}
}
