using System;

namespace WebCommon
{
	public class WPDBanWord : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.type);
			writer.Write(this.word);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.type = reader.ReadInt32();
			this.word = reader.ReadString();
		}

		public WPDBanWord()
		{
		}

		public int type;

		public string word;
	}
}
