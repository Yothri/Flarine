using System;

namespace WebCommon
{
	public class WPDMainQuestDialogue : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.mainQuestId);
			writer.Write(this.dialogueId);
			writer.Write(this.npcId);
			writer.Write(this.dialogue);
			writer.Write(this.dialogueKey);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.mainQuestId = reader.ReadInt32();
			this.dialogueId = reader.ReadInt32();
			this.npcId = reader.ReadInt32();
			this.dialogue = reader.ReadString();
			this.dialogueKey = reader.ReadString();
		}

		public WPDMainQuestDialogue()
		{
		}

		public int mainQuestId;

		public int dialogueId;

		public int npcId;

		public string dialogue;

		public string dialogueKey;
	}
}
