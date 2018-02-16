using System;

namespace WebCommon
{
	public class WPDPetInstance : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.petInstanceId);
			writer.Write(this.level);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.petInstanceId = reader.ReadInt32();
			this.level = reader.ReadInt32();
		}

		public WPDPetInstance()
		{
		}

		public int petInstanceId;

		public int level;
	}
}
