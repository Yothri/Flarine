using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBEnemyAddEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.addedEnemyId);
			writer.Write(this.removedEnemyId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.addedEnemyId = reader.ReadInt32();
			this.removedEnemyId = reader.ReadInt32();
		}

		public SEBEnemyAddEventBody()
		{
		}

		public int addedEnemyId;

		public int removedEnemyId;
	}
}
