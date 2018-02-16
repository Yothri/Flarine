using System;

namespace WebCommon
{
	public class WPDSocket : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroGearId);
			writer.Write(this.socketNo);
			writer.Write(this.itemId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroGearId = reader.ReadString();
			this.socketNo = reader.ReadInt32();
			this.itemId = reader.ReadInt32();
		}

		public WPDSocket()
		{
		}

		public string accountHeroGearId;

		public int socketNo;

		public int itemId;
	}
}
