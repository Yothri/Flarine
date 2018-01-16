using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBSystemMessageEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.systemMessageId);
			writer.Write(this.systemMessageValues);
			writer.Write(this.accountHeroId);
			writer.Write(this.chatItem);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.systemMessageId = reader.ReadInt32();
			this.systemMessageValues = reader.ReadPDPacketDatas<PDSystemMessageValue>();
			this.accountHeroId = reader.ReadInt32();
			this.chatItem = reader.ReadPDPacketData<PDChatItem>();
		}

		public SEBSystemMessageEventBody()
		{
		}

		public int systemMessageId;

		public PDSystemMessageValue[] systemMessageValues;

		public int accountHeroId;

		public PDChatItem chatItem;
	}
}
