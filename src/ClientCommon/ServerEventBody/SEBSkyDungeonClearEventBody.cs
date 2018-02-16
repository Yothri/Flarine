using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBSkyDungeonClearEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHero);
			writer.Write(this.clearGrade);
			writer.Write(this.playTime);
			writer.Write(this.rewardExp);
			writer.Write(this.rewardOwnGold);
			writer.Write(this.rewardRunePiece);
			writer.Write(this.mailSended);
			writer.Write(this.changedInventorySlots);
			writer.Write(this.pickEntries);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHero = reader.ReadPDPacketData<PDAccountHero>();
			this.clearGrade = reader.ReadInt32();
			this.playTime = reader.ReadInt32();
			this.rewardExp = reader.ReadInt32();
			this.rewardOwnGold = reader.ReadInt32();
			this.rewardRunePiece = reader.ReadPDReward<PDItemReward>();
			this.mailSended = reader.ReadBoolean();
			this.changedInventorySlots = reader.ReadPDPacketDatas<PDInventorySlot>();
			this.pickEntries = reader.ReadPDPacketDatas<PDSkyDungeonClearRewardPickEntry>();
		}

		public SEBSkyDungeonClearEventBody()
		{
		}

		public PDAccountHero accountHero;

		public int clearGrade;

		public int playTime;

		public int rewardExp;

		public int rewardOwnGold;

		public PDItemReward rewardRunePiece;

		public bool mailSended;

		public PDInventorySlot[] changedInventorySlots;

		public PDSkyDungeonClearRewardPickEntry[] pickEntries;
	}
}
