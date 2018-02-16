using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class WhisperChatCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.message);
			writer.Write(this.targetAccountHeroId);
			writer.Write(this.targetNicName);
			writer.Write(this.chatItemList);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.message = reader.ReadString();
			this.targetAccountHeroId = reader.ReadInt32();
			this.targetNicName = reader.ReadString();
			this.chatItemList = reader.ReadPDPacketDatas<PDChatItem>();
		}

		public WhisperChatCommandBody()
		{
		}

		public string message;

		public int targetAccountHeroId;

		public string targetNicName;

		public PDChatItem[] chatItemList;
	}
}
