using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBPartyDungeonMasterChangedEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.masterId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.masterId = reader.ReadInt32();
		}

		public SEBPartyDungeonMasterChangedEventBody()
		{
		}

		public int masterId;
	}
}
