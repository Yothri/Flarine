using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class PackageProductListResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.packageProducts);
			writer.Write(this.packageProductItems);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.packageProducts = reader.ReadPDPacketDatas<PDPackageProduct>();
			this.packageProductItems = reader.ReadPDPacketDatas<PDPackageProductItem>();
		}

		public PackageProductListResponseBody()
		{
		}

		public PDPackageProduct[] packageProducts;

		public PDPackageProductItem[] packageProductItems;
	}
}
