using System;

namespace WebCommon
{
	public class WPDLinkPlace : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.placeId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.continentId);
			writer.Write(this.xPosition);
			writer.Write(this.yPosition);
			writer.Write(this.zPosition);
			writer.Write(this.locationId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.placeId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.continentId = reader.ReadInt32();
			this.xPosition = reader.ReadDouble();
			this.yPosition = reader.ReadDouble();
			this.zPosition = reader.ReadDouble();
			this.locationId = reader.ReadInt32();
		}

		public WPDLinkPlace()
		{
		}

		public int placeId;

		public string name;

		public string nameKey;

		public int continentId;

		public double xPosition;

		public double yPosition;

		public double zPosition;

		public int locationId;
	}
}
