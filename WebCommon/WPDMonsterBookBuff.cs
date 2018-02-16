using System;

namespace WebCommon
{
	public class WPDMonsterBookBuff : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterCharacterId);
			writer.Write(this.attrId);
			writer.Write(this.value);
			writer.Write(this.continentId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterCharacterId = reader.ReadInt32();
			this.attrId = reader.ReadInt32();
			this.value = reader.ReadDouble();
			this.continentId = reader.ReadInt32();
		}

		public WPDMonsterBookBuff()
		{
		}

		public int monsterCharacterId;

		public int attrId;

		public double value;

		public int continentId;
	}
}
