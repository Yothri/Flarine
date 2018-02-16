using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroItemTypeUseCount : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.itemType);
			writer.Write(this.count);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.itemType = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public PDAccountHeroItemTypeUseCount()
		{
		}

		public int itemType;

		public int count;
	}
}
