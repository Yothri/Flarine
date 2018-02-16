using System;

namespace WebCommon
{
	public class WPDConstellation : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.constellationId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.requiredHeroLevel);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.constellationId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.requiredHeroLevel = reader.ReadInt32();
		}

		public WPDConstellation()
		{
		}

		public int constellationId;

		public string name;

		public string nameKey;

		public int requiredHeroLevel;
	}
}
