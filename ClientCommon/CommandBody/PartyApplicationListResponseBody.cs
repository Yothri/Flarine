using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PartyApplicationListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.apps);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.apps = reader.ReadPDPacketDatas<PDPartyApplication>();
		}

		public PartyApplicationListResponseBody()
		{
		}

		public PDPartyApplication[] apps;
	}
}
