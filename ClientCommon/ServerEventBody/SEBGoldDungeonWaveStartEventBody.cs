using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBGoldDungeonWaveStartEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.wave);
			writer.Write(this.monsterCount);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.wave = reader.ReadInt32();
			this.monsterCount = reader.ReadInt32();
		}

		public SEBGoldDungeonWaveStartEventBody()
		{
		}

		public int wave;

		public int monsterCount;
	}
}
