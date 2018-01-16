using System;

namespace WebCommon
{
	public class WPDGameTip : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tipNo);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
			writer.Write(this.imageName);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.tipNo = reader.ReadInt32();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
			this.imageName = reader.ReadString();
		}

		public WPDGameTip()
		{
		}

		public int tipNo;

		public string description;

		public string descriptionKey;

		public string imageName;
	}
}
