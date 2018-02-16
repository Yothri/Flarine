using System;

namespace ClientCommon.PacketData
{
	public class PDMonsterBookEntry : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterCharacterId);
			writer.Write(this.count);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterCharacterId = reader.ReadInt32();
			this.count = reader.ReadInt32();
		}

		public PDMonsterBookEntry()
		{
		}

		public int monsterCharacterId;

		public int count;
	}
}
