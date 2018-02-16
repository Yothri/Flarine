using System;

namespace WebCommon
{
	public class WPDLocation : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.locationId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.moneyBuffEnabled);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.locationId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.moneyBuffEnabled = reader.ReadBoolean();
		}

		public WPDLocation()
		{
		}

		public int locationId;

		public string name;

		public string nameKey;

		public bool moneyBuffEnabled;
	}
}
