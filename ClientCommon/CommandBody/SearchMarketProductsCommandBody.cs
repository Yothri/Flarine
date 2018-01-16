using System;

namespace ClientCommon.CommandBody
{
	public class SearchMarketProductsCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.nCategoryId1);
			writer.Write(this.nCategoryId2);
			writer.Write(this.nCategoryId3);
			writer.Write(this.bSortNameAsc);
			writer.Write(this.bSortTierAsc);
			writer.Write(this.bSortPriceAsc);
			writer.Write(this.bSortUnitPriceAsc);
			writer.Write(this.sSearch);
			writer.Write(this.nSearchGrade);
			writer.Write(this.nPaymentMoneyType);
			writer.Write(this.nPage);
			writer.Write(this.nRowsPerPage);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.nCategoryId1 = reader.ReadInt32();
			this.nCategoryId2 = reader.ReadInt32();
			this.nCategoryId3 = reader.ReadInt32();
			this.bSortNameAsc = reader.ReadBoolean();
			this.bSortTierAsc = reader.ReadBoolean();
			this.bSortPriceAsc = reader.ReadBoolean();
			this.bSortUnitPriceAsc = reader.ReadBoolean();
			this.sSearch = reader.ReadString();
			this.nSearchGrade = reader.ReadInt32();
			this.nPaymentMoneyType = reader.ReadInt32();
			this.nPage = reader.ReadInt32();
			this.nRowsPerPage = reader.ReadInt32();
		}

		public SearchMarketProductsCommandBody()
		{
		}

		public int nCategoryId1;

		public int nCategoryId2;

		public int nCategoryId3;

		public bool bSortNameAsc;

		public bool bSortTierAsc;

		public bool bSortPriceAsc;

		public bool bSortUnitPriceAsc;

		public string sSearch;

		public int nSearchGrade;

		public int nPaymentMoneyType;

		public int nPage;

		public int nRowsPerPage;
	}
}
