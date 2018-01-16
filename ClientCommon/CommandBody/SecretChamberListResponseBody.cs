using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class SecretChamberListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.items);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.items = reader.ReadPDPacketDatas<PDPartyDungeonListItem>();
		}

		public SecretChamberListResponseBody()
		{
		}

		public PDPartyDungeonListItem[] items;
	}
}
