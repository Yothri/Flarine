using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBGameNoticeEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.gameNotices);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.gameNotices = reader.ReadStrings();
		}

		public SEBGameNoticeEventBody()
		{
		}

		public string[] gameNotices;
	}
}
