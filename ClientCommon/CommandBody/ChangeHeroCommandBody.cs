using System;

namespace ClientCommon.CommandBody
{
	public class ChangeHeroCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.targetAccountHeroId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.targetAccountHeroId = reader.ReadInt32();
		}

		public ChangeHeroCommandBody()
		{
		}

		public int targetAccountHeroId;
	}
}
