using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBLevelUpPetEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.moveSpeed);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.moveSpeed = reader.ReadSingle();
		}

		public SEBLevelUpPetEventBody()
		{
		}

		public float moveSpeed;
	}
}
