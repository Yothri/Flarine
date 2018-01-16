using System;

namespace WebCommon
{
	public class WPDFullMoonBuff : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.buffId);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.description);
			writer.Write(this.descriptionKey);
			writer.Write(this.attrId);
			writer.Write(this.value);
			writer.Write(this.colorCode);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.buffId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.description = reader.ReadString();
			this.descriptionKey = reader.ReadString();
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
			this.colorCode = reader.ReadString();
		}

		public WPDFullMoonBuff()
		{
		}

		public int buffId;

		public string name;

		public string nameKey;

		public string description;

		public string descriptionKey;

		public int attrId;

		public double value;

		public string colorCode;
	}
}
