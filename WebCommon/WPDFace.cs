using System;

namespace WebCommon
{
	public class WPDFace : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.faceId);
			writer.Write(this.heroId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.faceId = reader.ReadInt32();
			this.heroId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
		}

		public WPDFace()
		{
		}

		public int faceId;

		public int heroId;

		public string name;

		public string nameKey;
	}
}
