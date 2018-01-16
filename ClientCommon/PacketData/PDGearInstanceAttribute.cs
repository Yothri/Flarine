using System;

namespace ClientCommon.PacketData
{
	public class PDGearInstanceAttribute : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gearInstanceId);
			writer.Write(this.type);
			writer.Write(this.id);
			writer.Write(this.value);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.gearInstanceId = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.id = reader.ReadInt32();
			this.value = reader.ReadSingle();
		}

		public PDGearInstanceAttribute()
		{
		}

		public int gearInstanceId;

		public int type;

		public int id;

		public float value;
	}
}
