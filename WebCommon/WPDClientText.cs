using System;

namespace WebCommon
{
	public class WPDClientText : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.name);
			writer.Write(this.value);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.name = reader.ReadString();
			this.value = reader.ReadString();
		}

		public WPDClientText()
		{
		}

		public string name;

		public string value;
	}
}
