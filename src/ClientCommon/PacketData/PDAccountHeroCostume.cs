using System;

namespace ClientCommon.PacketData
{
	public class PDAccountHeroCostume : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.level);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadInt32();
			this.level = reader.ReadInt32();
		}

		public PDAccountHeroCostume()
		{
		}

		public int id;

		public int level;
	}
}
