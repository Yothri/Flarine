using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBStartTakeOffMotionEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
		}

		public SEBStartTakeOffMotionEventBody()
		{
		}

		public int accountHeroId;
	}
}
