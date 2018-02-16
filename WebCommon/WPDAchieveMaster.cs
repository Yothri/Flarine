using System;

namespace WebCommon
{
	public class WPDAchieveMaster : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.achieveMasterId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.achieveMasterId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
		}

		public WPDAchieveMaster()
		{
		}

		public int achieveMasterId;

		public string name;

		public string nameKey;
	}
}
