using System;

namespace ClientCommon.PacketData
{
	public class PDSystemMessageValue : PDPacketData
	{
		public PDSystemMessageValue() : this(0, null)
		{
		}

		public PDSystemMessageValue(int nType, string sValue)
		{
			this.type = nType;
			this.value = sValue;
		}

		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.type);
			writer.Write(this.value);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.type = reader.ReadInt32();
			this.value = reader.ReadString();
		}

		public int type;

		public string value;
	}
}
