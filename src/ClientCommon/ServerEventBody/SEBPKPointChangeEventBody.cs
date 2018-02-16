using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBPKPointChangeEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.pkPoint);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.pkPoint = reader.ReadInt32();
		}

		public SEBPKPointChangeEventBody()
		{
		}

		public int accountHeroId;

		public int pkPoint;
	}
}
