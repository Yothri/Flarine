using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBActualTrainingExitEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.hp);
			writer.Write(this.continentId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.hp = reader.ReadInt32();
			this.continentId = reader.ReadInt32();
		}

		public SEBActualTrainingExitEventBody()
		{
		}

		public int hp;

		public int continentId;
	}
}
