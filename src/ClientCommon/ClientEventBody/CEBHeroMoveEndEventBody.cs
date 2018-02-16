using System;

namespace ClientCommon.ClientEventBody
{
	public class CEBHeroMoveEndEventBody : CEBClientEventBody
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

		public CEBHeroMoveEndEventBody()
		{
		}

		public int accountHeroId;
	}
}
