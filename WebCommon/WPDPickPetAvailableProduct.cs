using System;

namespace WebCommon
{
	public class WPDPickPetAvailableProduct : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storeId);
			writer.Write(this.categoryId);
			writer.Write(this.productNo);
			writer.Write(this.petId);
			writer.Write(this.petInstanceId);
			writer.Write(this.sortNo);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.storeId = reader.ReadInt32();
			this.categoryId = reader.ReadInt32();
			this.productNo = reader.ReadInt32();
			this.petId = reader.ReadInt32();
			this.petInstanceId = reader.ReadInt32();
			this.sortNo = reader.ReadInt32();
		}

		public WPDPickPetAvailableProduct()
		{
		}

		public int storeId;

		public int categoryId;

		public int productNo;

		public int petId;

		public int petInstanceId;

		public int sortNo;
	}
}
