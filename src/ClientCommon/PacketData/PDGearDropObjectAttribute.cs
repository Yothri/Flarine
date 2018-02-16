using System;

namespace ClientCommon.PacketData
{
	public class PDGearDropObjectAttribute : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.type);
			writer.Write(this.id);
			writer.Write(this.value);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.type = reader.ReadInt32();
			this.id = reader.ReadInt32();
			this.value = reader.ReadSingle();
		}

		public PDGearDropObjectAttribute()
		{
		}

		public int type;

		public int id;

		public float value;
	}
}
