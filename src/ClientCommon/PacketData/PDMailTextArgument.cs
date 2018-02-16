using System;

namespace ClientCommon.PacketData
{
	public class PDMailTextArgument : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.valueType);
			writer.Write(this.value);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.valueType = reader.ReadInt32();
			this.value = reader.ReadString();
		}

		public PDMailTextArgument()
		{
		}

		public int valueType;

		public string value;
	}
}
