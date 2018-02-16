using System;

namespace ClientCommon.PacketData
{
	public class PDLastTaskEntry : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.count);
			writer.Write(this.rewarded);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.count = reader.ReadInt32();
			this.rewarded = reader.ReadBoolean();
		}

		public PDLastTaskEntry()
		{
		}

		public int entryId;

		public int count;

		public bool rewarded;
	}
}
