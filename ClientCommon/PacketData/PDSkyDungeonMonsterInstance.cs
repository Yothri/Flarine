using System;

namespace ClientCommon.PacketData
{
	public class PDSkyDungeonMonsterInstance : PDMonsterInstance
	{
		public override int instanceType
		{
			get
			{
				return 140;
			}
		}

		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterType);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterType = reader.ReadInt32();
		}

		public PDSkyDungeonMonsterInstance()
		{
		}

		public int monsterType;
	}
}
