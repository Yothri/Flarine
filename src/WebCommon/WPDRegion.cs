using System;

namespace WebCommon
{
	public class WPDRegion : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.regionId);
			writer.Write(this.continentId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.regionId = reader.ReadInt32();
			this.continentId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
		}

		public WPDRegion()
		{
		}

		public int regionId;

		public int continentId;

		public string name;

		public string nameKey;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;
	}
}
