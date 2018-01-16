using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class FallenCityListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.items);
			writer.Write(this.abnormalPlayRewarded);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.items = reader.ReadPDPacketDatas<PDPartyDungeonListItem>();
			this.abnormalPlayRewarded = reader.ReadBoolean();
		}

		public FallenCityListResponseBody()
		{
		}

		public PDPartyDungeonListItem[] items;

		public bool abnormalPlayRewarded;
	}
}
