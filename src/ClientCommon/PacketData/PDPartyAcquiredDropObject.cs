using System;

namespace ClientCommon.PacketData
{
	public class PDPartyAcquiredDropObject : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.type);
			writer.Write(this.owned);
			writer.Write(this.itemId);
			writer.Write(this.eq_gearId);
			writer.Write(this.eq_grade);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.type = reader.ReadInt32();
			this.owned = reader.ReadBoolean();
			this.itemId = reader.ReadInt32();
			this.eq_gearId = reader.ReadInt32();
			this.eq_grade = reader.ReadInt32();
		}

		public PDPartyAcquiredDropObject()
		{
		}

		public const int kType_Gear = 1;

		public const int kType_Item = 2;

		public int type;

		public bool owned;

		public int itemId;

		public int eq_gearId;

		public int eq_grade;
	}
}
