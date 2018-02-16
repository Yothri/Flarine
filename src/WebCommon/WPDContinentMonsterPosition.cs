using System;

namespace WebCommon
{
	public class WPDContinentMonsterPosition : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
			writer.Write(this.monsterCharacterId);
			writer.Write(this.type);
			writer.Write(this.xPosition);
			writer.Write(this.yPosition);
			writer.Write(this.zPosition);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.level);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
			this.monsterCharacterId = reader.ReadInt32();
			this.type = reader.ReadInt32();
			this.xPosition = reader.ReadDouble();
			this.yPosition = reader.ReadDouble();
			this.zPosition = reader.ReadDouble();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.level = reader.ReadInt32();
		}

		public WPDContinentMonsterPosition()
		{
		}

		public int continentId;

		public int monsterCharacterId;

		public int type;

		public double xPosition;

		public double yPosition;

		public double zPosition;

		public string name;

		public string nameKey;

		public int level;
	}
}
