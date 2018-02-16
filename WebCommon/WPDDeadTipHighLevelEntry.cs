using System;

namespace WebCommon
{
	public class WPDDeadTipHighLevelEntry : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.entryId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.currentName);
			writer.Write(this.currentNameKey);
			writer.Write(this.recommendName);
			writer.Write(this.recommendNameKey);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.entryId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.currentName = reader.ReadString();
			this.currentNameKey = reader.ReadString();
			this.recommendName = reader.ReadString();
			this.recommendNameKey = reader.ReadString();
		}

		public WPDDeadTipHighLevelEntry()
		{
		}

		public int entryId;

		public string name;

		public string nameKey;

		public string currentName;

		public string currentNameKey;

		public string recommendName;

		public string recommendNameKey;
	}
}
