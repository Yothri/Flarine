using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class LimitedProductMasterInfoResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.limitedProductMasters);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.limitedProductMasters = reader.ReadPDPacketDatas<PDLimitedProductMaster>();
		}

		public LimitedProductMasterInfoResponseBody()
		{
		}

		public PDLimitedProductMaster[] limitedProductMasters;
	}
}
