using System;

namespace WebCommon
{
	public class WPDFame : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.fameId);
			writer.Write(this.point);
			writer.Write(this.title);
			writer.Write(this.titleKey);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.fameId = reader.ReadInt32();
			this.point = reader.ReadInt32();
			this.title = reader.ReadString();
			this.titleKey = reader.ReadString();
		}

		public WPDFame()
		{
		}

		public int fameId;

		public int point;

		public string title;

		public string titleKey;
	}
}
