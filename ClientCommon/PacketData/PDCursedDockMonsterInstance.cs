using System;

namespace ClientCommon.PacketData
{
	public class PDCursedDockMonsterInstance : PDMonsterInstance
	{
		public override int instanceType
		{
			get
			{
				return 50;
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

		public PDCursedDockMonsterInstance()
		{
		}

		public int monsterType;
	}
}
