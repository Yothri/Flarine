using System;
using System.IO;
using System.Text;

namespace WebCommon
{
	public class WPacketWriter : WBinWriter
	{
		public WPacketWriter()
		{
		}

		public WPacketWriter(Stream output) : base(output)
		{
		}

		public WPacketWriter(Stream output, Encoding encoding) : base(output, encoding)
		{
		}

		public void Write(WPDPacketData value)
		{
			if (value == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			value.Serialize(this);
		}

		public void Write(WPDPacketData[] values)
		{
			if (values == null)
			{
				this.Write(false);
				return;
			}
			this.Write(true);
			this.Write(values.Length);
			foreach (WPDPacketData value in values)
			{
				this.Write(value);
			}
		}
	}
}
