using System;

namespace ClientCommon.CommandBody
{
	public class PurchaseProductCompleteResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dia);
			writer.Write(this.ownDia);
			writer.Write(this.vipLevel);
			writer.Write(this.vipPoint);
			writer.Write(this.totalPurchasedDia);
			writer.Write(this.isFirstPurchase);
			writer.Write(this.purchaseTime);
			writer.Write(this.day30StartDate);
			writer.Write(this.day30EndDate);
			writer.Write(this.day30DiaStartDate);
			writer.Write(this.day30DiaEndDate);
			writer.Write(this.levelUpPackageRemainingTime);
			writer.Write(this.levelUpPackage2RemainingTime);
			writer.Write(this.levelUpPackage3RemainingTime);
			writer.Write(this.firstChargeEventAccomplished);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.dia = reader.ReadInt32();
			this.ownDia = reader.ReadInt32();
			this.vipLevel = reader.ReadInt32();
			this.vipPoint = reader.ReadInt32();
			this.totalPurchasedDia = reader.ReadInt32();
			this.isFirstPurchase = reader.ReadBoolean();
			this.purchaseTime = reader.ReadDateTimeOffset();
			this.day30StartDate = reader.ReadNullableDateTime();
			this.day30EndDate = reader.ReadNullableDateTime();
			this.day30DiaStartDate = reader.ReadNullableDateTime();
			this.day30DiaEndDate = reader.ReadNullableDateTime();
			this.levelUpPackageRemainingTime = reader.ReadSingle();
			this.levelUpPackage2RemainingTime = reader.ReadSingle();
			this.levelUpPackage3RemainingTime = reader.ReadSingle();
			this.firstChargeEventAccomplished = reader.ReadBoolean();
		}

		public PurchaseProductCompleteResponseBody()
		{
		}

		public int dia;

		public int ownDia;

		public int vipLevel;

		public int vipPoint;

		public int totalPurchasedDia;

		public bool isFirstPurchase;

		public DateTimeOffset purchaseTime;

		public DateTime? day30StartDate;

		public DateTime? day30EndDate;

		public DateTime? day30DiaStartDate;

		public DateTime? day30DiaEndDate;

		public float levelUpPackageRemainingTime;

		public float levelUpPackage2RemainingTime;

		public float levelUpPackage3RemainingTime;

		public bool firstChargeEventAccomplished;
	}
}
