using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBExpDungeonWaveStartEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.wave);
			writer.Write(this.monsters);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.wave = reader.ReadInt32();
			this.monsters = reader.ReadPDMonsterInstances<PDExpDungeonMonsterInstance>();
		}

		public SEBExpDungeonWaveStartEventBody()
		{
		}

		public int wave;

		public PDExpDungeonMonsterInstance[] monsters;
	}
}
