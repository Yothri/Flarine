using System;

namespace WebCommon
{
	public class WPDPortal : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.portalId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.continentId);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.linkedPortalId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.portalId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.continentId = reader.ReadInt32();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.linkedPortalId = reader.ReadInt32();
		}

		public WPDPortal()
		{
		}

		public int portalId;

		public string name;

		public string nameKey;

		public int continentId;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public int linkedPortalId;
	}
}
