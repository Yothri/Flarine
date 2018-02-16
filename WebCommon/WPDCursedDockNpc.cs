using System;

namespace WebCommon
{
	public class WPDCursedDockNpc : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.level);
			writer.Write(this.maxHp);
			writer.Write(this.physicalDefense);
			writer.Write(this.magicalDefense);
			writer.Write(this.dodge);
			writer.Write(this.moveSpeed);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.level = reader.ReadInt32();
			this.maxHp = reader.ReadInt32();
			this.physicalDefense = reader.ReadInt32();
			this.magicalDefense = reader.ReadInt32();
			this.dodge = reader.ReadInt32();
			this.moveSpeed = reader.ReadDouble();
		}

		public WPDCursedDockNpc()
		{
		}

		public string name;

		public string nameKey;

		public int level;

		public int maxHp;

		public int physicalDefense;

		public int magicalDefense;

		public int dodge;

		public double moveSpeed;
	}
}
