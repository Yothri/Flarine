﻿using System;

namespace ClientCommon.PacketData
{
	public class PDGuildBattlefieldStatue : PDPacketData
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.id);
			writer.Write(this.guildId);
			writer.Write(this.guildName);
			writer.Write(this.accountHeroId);
			writer.Write(this.name);
			writer.Write(this.heroId);
			writer.Write(this.tradition);
			writer.Write(this.level);
			writer.Write(this.battlePower);
			writer.Write(this.costumeId);
			writer.Write(this.costumeVisible);
			writer.Write(this.mountTier);
			writer.Write(this.equippedGears);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.id = reader.ReadGuid();
			this.guildId = reader.ReadGuid();
			this.guildName = reader.ReadString();
			this.accountHeroId = reader.ReadInt32();
			this.name = reader.ReadString();
			this.heroId = reader.ReadInt32();
			this.tradition = reader.ReadInt32();
			this.level = reader.ReadInt32();
			this.battlePower = reader.ReadInt32();
			this.costumeId = reader.ReadInt32();
			this.costumeVisible = reader.ReadBoolean();
			this.mountTier = reader.ReadInt32();
			this.equippedGears = reader.ReadPDPacketDatas<PDGuildBattlefieldStatueEquippedGear>();
		}

		public PDGuildBattlefieldStatue()
		{
		}

		public Guid id;

		public Guid guildId;

		public string guildName;

		public int accountHeroId;

		public string name;

		public int heroId;

		public int tradition;

		public int level;

		public int battlePower;

		public int costumeId;

		public bool costumeVisible;

		public int mountTier;

		public PDGuildBattlefieldStatueEquippedGear[] equippedGears;
	}
}
