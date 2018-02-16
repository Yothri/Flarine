using System;

namespace ClientCommon.PacketData
{
	public class PDPetInstanceAttribute : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.petInstanceId);
			writer.Write(this.id);
			writer.Write(this.value);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.petInstanceId = reader.ReadInt32();
			this.id = reader.ReadInt32();
			this.value = reader.ReadSingle();
		}

		public PDPetInstanceAttribute()
		{
		}

		public int petInstanceId;

		public int id;

		public float value;
	}
}
