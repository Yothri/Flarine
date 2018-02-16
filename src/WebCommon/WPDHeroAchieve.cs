using System;

namespace WebCommon
{
	public class WPDHeroAchieve : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.heroId);
			writer.Write(this.achieveId);
			writer.Write(this.title);
			writer.Write(this.titleKey);
			writer.Write(this.point);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.heroId = reader.ReadInt32();
			this.achieveId = reader.ReadInt32();
			this.title = reader.ReadString();
			this.titleKey = reader.ReadString();
			this.point = reader.ReadInt32();
		}

		public WPDHeroAchieve()
		{
		}

		public int heroId;

		public int achieveId;

		public string title;

		public string titleKey;

		public int point;
	}
}
