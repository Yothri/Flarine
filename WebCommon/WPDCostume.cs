using System;

namespace WebCommon
{
	public class WPDCostume : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.costumeId);
			writer.Write(this.type);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
			writer.Write(this.heroId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.costumeId = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
			this.heroId = reader.ReadInt32();
		}

		public WPDCostume()
		{
		}

		public int costumeId;

		public int type;

		public string name;

		public string nameKey;

		public string description;

		public string descriptionKey;

		public int heroId;
	}
}
