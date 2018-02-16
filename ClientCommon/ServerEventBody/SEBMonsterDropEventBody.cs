using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBMonsterDropEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterInstanceId);
			writer.Write(this.dropObject);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterInstanceId = reader.ReadInt64();
			this.dropObject = reader.ReadPDPacketData<PDDropObject>();
		}

		public SEBMonsterDropEventBody()
		{
		}

		public long monsterInstanceId;

		public PDDropObject dropObject;
	}
}
