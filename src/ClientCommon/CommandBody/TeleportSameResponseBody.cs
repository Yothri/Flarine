﻿using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class TeleportSameResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.addedAccountHeroes);
			writer.Write(this.addedMonsters);
			writer.Write(this.addedDropObjects);
			writer.Write(this.removedAccountHeroes);
			writer.Write(this.removedMonsters);
			writer.Write(this.removedDropObjects);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.addedAccountHeroes = reader.ReadPDPacketDatas<PDAccountHero>();
			this.addedMonsters = reader.ReadPDMonsterInstances<PDMonsterInstance>();
			this.addedDropObjects = reader.ReadPDPacketDatas<PDDropObject>();
			this.removedAccountHeroes = reader.ReadInts();
			this.removedMonsters = reader.ReadLongs();
			this.removedDropObjects = reader.ReadLongs();
		}

		public TeleportSameResponseBody()
		{
		}

		public PDAccountHero[] addedAccountHeroes;

		public PDMonsterInstance[] addedMonsters;

		public PDDropObject[] addedDropObjects;

		public int[] removedAccountHeroes;

		public long[] removedMonsters;

		public long[] removedDropObjects;
	}
}
