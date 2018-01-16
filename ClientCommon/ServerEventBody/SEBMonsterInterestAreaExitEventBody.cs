using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBMonsterInterestAreaExitEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterInstanceId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterInstanceId = reader.ReadInt64();
		}

		public SEBMonsterInterestAreaExitEventBody()
		{
		}

		public long monsterInstanceId;
	}
}
