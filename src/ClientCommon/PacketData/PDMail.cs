using System;

namespace ClientCommon.PacketData
{
	public class PDMail : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.titleType);
			writer.Write(this.title);
			writer.Write(this.titleTextArgs);
			writer.Write(this.contentType);
			writer.Write(this.content);
			writer.Write(this.contentTextArgs);
			writer.Write(this.senderName);
			writer.Write(this.ownGold);
			writer.Write(this.ownDia);
			writer.Write(this.bonusDia);
			writer.Write(this.magicPowder);
			writer.Write(this.remainTime);
			writer.Write(this.opened);
			writer.Write(this.received);
			writer.Write(this.mailAttachments);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadGuid();
			this.titleType = reader.ReadInt32();
			this.title = reader.ReadString();
			this.titleTextArgs = reader.ReadPDPacketDatas<PDMailTextArgument>();
			this.contentType = reader.ReadInt32();
			this.content = reader.ReadString();
			this.contentTextArgs = reader.ReadPDPacketDatas<PDMailTextArgument>();
			this.senderName = reader.ReadString();
			this.ownGold = reader.ReadInt32();
			this.ownDia = reader.ReadInt32();
			this.bonusDia = reader.ReadInt32();
			this.magicPowder = reader.ReadInt32();
			this.remainTime = reader.ReadInt32();
			this.opened = reader.ReadBoolean();
			this.received = reader.ReadBoolean();
			this.mailAttachments = reader.ReadPDPacketDatas<PDMailAttachment>();
		}

		public PDMail()
		{
		}

		public Guid id;

		public int titleType;

		public string title;

		public PDMailTextArgument[] titleTextArgs;

		public int contentType;

		public string content;

		public PDMailTextArgument[] contentTextArgs;

		public string senderName;

		public int ownGold;

		public int ownDia;

		public int bonusDia;

		public int magicPowder;

		public int remainTime;

		public bool opened;

		public bool received;

		public PDMailAttachment[] mailAttachments;
	}
}
