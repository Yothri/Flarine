using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBPartyMasterChangedEventBody : SEBServerEventBody
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

		public SEBPartyMasterChangedEventBody()
		{
		}

		public int masterId;
	}
}
