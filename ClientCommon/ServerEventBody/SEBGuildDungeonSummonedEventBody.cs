using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBGuildDungeonSummonedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsters);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsters = reader.ReadPDMonsterInstances<PDGuildDungeonSummonMonsterInstance>();
		}

		public SEBGuildDungeonSummonedEventBody()
		{
		}

		public PDGuildDungeonSummonMonsterInstance[] monsters;
	}
}
