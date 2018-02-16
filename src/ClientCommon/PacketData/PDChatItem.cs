using System;

namespace ClientCommon.PacketData
{
	public class PDChatItem : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.type);
			writer.Write(this.position);
			writer.Write(this.itemId);
			writer.Write(this.owned);
			writer.Write(this.accountHeroGearId);
			writer.Write(this.isBlessed);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.type = reader.ReadInt32();
			this.position = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
			this.owned = reader.ReadBoolean();
			this.accountHeroGearId = reader.ReadGuid();
			this.isBlessed = reader.ReadBoolean();
		}

		public PDChatItem()
		{
		}

		public const int kType_Gear = 1;

		public const int kType_Item = 2;

		public const int kType_Pet = 3;

		public int type;

		public int position;

		public int itemId;

		public bool owned;

		public Guid accountHeroGearId;

		public bool isBlessed;
	}
}
