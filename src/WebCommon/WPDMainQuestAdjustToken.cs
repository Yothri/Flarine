using System;

namespace WebCommon
{
	public class WPDMainQuestAdjustToken : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mainQuestId);
			writer.Write(this.token);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.mainQuestId = reader.ReadInt32();
			this.token = reader.ReadString();
		}

		public WPDMainQuestAdjustToken()
		{
		}

		public int mainQuestId;

		public string token;
	}
}
