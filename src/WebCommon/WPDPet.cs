using System;

namespace WebCommon
{
	public class WPDPet : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.petId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.phaseId);
			writer.Write(this.heroId);
			writer.Write(this.requiredHeroLevel);
			writer.Write(this.ridable);
			writer.Write(this.viewScale);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.petId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.phaseId = reader.ReadInt32();
			this.heroId = reader.ReadInt32();
			this.requiredHeroLevel = reader.ReadInt32();
			this.ridable = reader.ReadBoolean();
			this.viewScale = reader.ReadDouble();
		}

		public WPDPet()
		{
		}

		public int petId;

		public string name;

		public string nameKey;

		public int phaseId;

		public int heroId;

		public int requiredHeroLevel;

		public bool ridable;

		public double viewScale;
	}
}
