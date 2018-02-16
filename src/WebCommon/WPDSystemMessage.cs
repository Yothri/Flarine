using System;

namespace WebCommon
{
	public class WPDSystemMessage : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.messageId);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
			writer.Write(this.applyType);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.messageId = reader.ReadInt32();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
			this.applyType = reader.ReadInt32();
		}

		public WPDSystemMessage()
		{
		}

		public int messageId;

		public string description;

		public string descriptionKey;

		public int applyType;
	}
}
