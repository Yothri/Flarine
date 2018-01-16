using System;
using ClientCommon.PacketData;

namespace ClientCommon.ClientEventBody
{
	public class CEBChatEventBody : CEBClientEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.chatType);
			writer.Write(this.message);
			writer.Write(this.chatItemList);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.chatType = reader.ReadByte();
			this.message = reader.ReadString();
			this.chatItemList = reader.ReadPDPacketDatas<PDChatItem>();
		}

		public CEBChatEventBody()
		{
		}

		public byte chatType;

		public string message;

		public PDChatItem[] chatItemList;
	}
}
