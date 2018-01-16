using System;

namespace WebCommon
{
	public class WPDSecretChamberFloorPortal : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.floor);
			writer.Write(this.portalId);
			writer.Write(this.xPosition);
			writer.Write(this.yPosition);
			writer.Write(this.zPosition);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.floor = reader.ReadInt32();
			this.portalId = reader.ReadInt32();
			this.xPosition = reader.ReadDouble();
			this.yPosition = reader.ReadDouble();
			this.zPosition = reader.ReadDouble();
		}

		public WPDSecretChamberFloorPortal()
		{
		}

		public int floor;

		public int portalId;

		public double xPosition;

		public double yPosition;

		public double zPosition;
	}
}
