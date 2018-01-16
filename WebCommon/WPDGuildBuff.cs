using System;

namespace WebCommon
{
	public class WPDGuildBuff : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.buffId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.consumeGuildPoint);
			writer.Write(this.isGuildLevel);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.buffId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.consumeGuildPoint = reader.ReadInt32();
			this.isGuildLevel = reader.ReadBoolean();
		}

		public WPDGuildBuff()
		{
		}

		public int buffId;

		public string name;

		public string nameKey;

		public int consumeGuildPoint;

		public bool isGuildLevel;
	}
}
