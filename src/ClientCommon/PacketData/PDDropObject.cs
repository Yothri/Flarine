using System;

namespace ClientCommon.PacketData
{
	public class PDDropObject : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.type);
			writer.Write(this.owned);
			writer.Write(this.ownerId);
			writer.Write(this.position);
			writer.Write(this.itemId);
			writer.Write(this.gold);
			writer.Write(this.eq_gearId);
			writer.Write(this.eq_grade);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt64();
			this.type = reader.ReadInt32();
			this.owned = reader.ReadBoolean();
			this.ownerId = reader.ReadInt32();
			this.position = reader.ReadPDVector3();
			this.itemId = reader.ReadInt32();
			this.gold = reader.ReadInt32();
			this.eq_gearId = reader.ReadInt32();
			this.eq_grade = reader.ReadInt32();
		}

		public PDDropObject()
		{
		}

		public const int kType_Gear = 1;

		public const int kType_Item = 2;

		public const int kType_Gold = 3;

		public long id;

		public int type;

		public bool owned;

		public int ownerId;

		public PDVector3 position;

		public int itemId;

		public int gold;

		public int eq_gearId;

		public int eq_grade;
	}
}
