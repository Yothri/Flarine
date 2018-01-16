using System;

namespace ClientCommon.PacketData
{
	public class PDPetInstance : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.level);
			writer.Write(this.attributes);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.attributes = reader.ReadPDPacketDatas<PDPetInstanceAttribute>();
		}

		public PDPetInstance()
		{
		}

		public int id;

		public int level;

		public PDPetInstanceAttribute[] attributes;
	}
}
