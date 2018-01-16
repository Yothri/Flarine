using System;

namespace ClientCommon.PacketData
{
	public class PDMainQuestDialogue : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mainQuestId);
			writer.Write(this.id);
			writer.Write(this.npcId);
			writer.Write(this.dialogueKey);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.mainQuestId = reader.ReadInt32();
			this.id = reader.ReadInt32();
			this.npcId = reader.ReadInt32();
			this.dialogueKey = reader.ReadString();
		}

		public PDMainQuestDialogue()
		{
		}

		public int mainQuestId;

		public int id;

		public int npcId;

		public string dialogueKey;
	}
}
