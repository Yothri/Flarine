using System;

namespace WebCommon
{
	public class WPDPvpMode : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.pvpModeId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.pvpModeId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
		}

		public WPDPvpMode()
		{
		}

		public int pvpModeId;

		public string name;

		public string nameKey;

		public string description;

		public string descriptionKey;
	}
}
