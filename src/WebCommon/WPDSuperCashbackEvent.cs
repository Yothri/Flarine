using System;

namespace WebCommon
{
	public class WPDSuperCashbackEvent : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
		}

		public WPDSuperCashbackEvent()
		{
		}

		public string name;

		public string nameKey;

		public string description;

		public string descriptionKey;
	}
}
