using System;
using System.IO;
using System.Text;
using ClientCommon.PacketData;

namespace ClientCommon
{
	public class PacketWriter : BinWriter
	{
		public PacketWriter()
		{
		}

		public PacketWriter(Stream output) : base(output)
		{
		}

		public PacketWriter(Stream output, Encoding encoding) : base(output, encoding)
		{
		}

		public void Write(PDVector3 value)
		{
			this.Write(value.x);
			this.Write(value.y);
			this.Write(value.z);
		}

		public void Write(PDPacketData value)
		{
			if (value == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			value.Serialize(this);
		}

		public void Write(PDPacketData[] values)
		{
			if (values == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			this.Write(values.Length);
			foreach (PDPacketData value in values)
			{
				this.Write(value);
			}
		}
	}
}
