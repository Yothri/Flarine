using System;

namespace WebCommon
{
	public class WPDNpc : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.npcId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
			writer.Write(this.continentId);
			writer.Write(this.xPosition);
			writer.Write(this.yPosition);
			writer.Write(this.zPosition);
			writer.Write(this.yRotation);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.npcId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
			this.continentId = reader.ReadInt32();
			this.xPosition = reader.ReadDouble();
			this.yPosition = reader.ReadDouble();
			this.zPosition = reader.ReadDouble();
			this.yRotation = reader.ReadDouble();
		}

		public WPDNpc()
		{
		}

		public int npcId;

		public string name;

		public string nameKey;

		public string description;

		public string descriptionKey;

		public int continentId;

		public double xPosition;

		public double yPosition;

		public double zPosition;

		public double yRotation;
	}
}
