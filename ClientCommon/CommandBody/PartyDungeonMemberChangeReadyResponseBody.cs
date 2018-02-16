using System;

namespace ClientCommon.CommandBody
{
	public class PartyDungeonMemberChangeReadyResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.ready);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.ready = reader.ReadBoolean();
		}

		public PartyDungeonMemberChangeReadyResponseBody()
		{
		}

		public bool ready;
	}
}
