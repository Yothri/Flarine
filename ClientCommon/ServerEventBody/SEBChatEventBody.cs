using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBChatEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.chatType);
			writer.Write(this.message);
			writer.Write(this.senderAccountHeroId);
			writer.Write(this.senderNicName);
			writer.Write(this.targetAccountHeroId);
			writer.Write(this.targetNicName);
			writer.Write(this.languageId);
			writer.Write(this.chatItemList);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.chatType = reader.ReadByte();
			this.message = reader.ReadString();
			this.senderAccountHeroId = reader.ReadInt32();
			this.senderNicName = reader.ReadString();
			this.targetAccountHeroId = reader.ReadInt32();
			this.targetNicName = reader.ReadString();
			this.languageId = reader.ReadInt32();
			this.chatItemList = reader.ReadPDPacketDatas<PDChatItem>();
		}

		public SEBChatEventBody()
		{
		}

		public byte chatType;

		public string message;

		public int senderAccountHeroId;

		public string senderNicName;

		public int targetAccountHeroId;

		public string targetNicName;

		public int languageId;

		public PDChatItem[] chatItemList;
	}
}
