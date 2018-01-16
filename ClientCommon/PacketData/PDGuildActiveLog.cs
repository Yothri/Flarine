using System;

namespace ClientCommon.PacketData
{
	public class PDGuildActiveLog : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.type);
			writer.Write(this.accountHeroName);
			writer.Write(this.waterOfLife);
			writer.Write(this.unOwnGold);
			writer.Write(this.donationCount);
			writer.Write(this.oldMemberGrade);
			writer.Write(this.newMemberGrade);
			writer.Write(this.guildDungeonInstanceId);
			writer.Write(this.dungeonId);
			writer.Write(this.damage);
			writer.Write(this.regTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.type = reader.ReadInt32();
			this.accountHeroName = reader.ReadString();
			this.waterOfLife = reader.ReadInt32();
			this.unOwnGold = reader.ReadInt32();
			this.donationCount = reader.ReadInt32();
			this.oldMemberGrade = reader.ReadInt32();
			this.newMemberGrade = reader.ReadInt32();
			this.guildDungeonInstanceId = reader.ReadNullableGuid();
			this.dungeonId = reader.ReadInt32();
			this.damage = reader.ReadInt32();
			this.regTime = reader.ReadString();
		}

		public PDGuildActiveLog()
		{
		}

		public int type;

		public string accountHeroName;

		public int waterOfLife;

		public int unOwnGold;

		public int donationCount;

		public int oldMemberGrade;

		public int newMemberGrade;

		public Guid? guildDungeonInstanceId = new Guid?(Guid.Empty);

		public int dungeonId;

		public int damage;

		public string regTime;
	}
}
