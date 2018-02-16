using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class EnterPrevPlaceResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.continentId);
			writer.Write(this.accountHeroes);
			writer.Write(this.monsters);
			writer.Write(this.dropObjects);
			writer.Write(this.arenaStatue);
			writer.Write(this.guildBattlefieldStatue);
			writer.Write(this.hp);
			writer.Write(this.position);
			writer.Write(this.rotationY);
			writer.Write(this.isFlying);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.continentId = reader.ReadInt32();
			this.accountHeroes = reader.ReadPDPacketDatas<PDAccountHero>();
			this.monsters = reader.ReadPDMonsterInstances<PDMonsterInstance>();
			this.dropObjects = reader.ReadPDPacketDatas<PDDropObject>();
			this.arenaStatue = reader.ReadPDPacketData<PDArenaStatue>();
			this.guildBattlefieldStatue = reader.ReadPDPacketData<PDGuildBattlefieldStatue>();
			this.hp = reader.ReadInt32();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
			this.isFlying = reader.ReadBoolean();
		}

		public EnterPrevPlaceResponseBody()
		{
		}

		public int continentId;

		public PDAccountHero[] accountHeroes;

		public PDMonsterInstance[] monsters;

		public PDDropObject[] dropObjects;

		public PDArenaStatue arenaStatue;

		public PDGuildBattlefieldStatue guildBattlefieldStatue;

		public int hp;

		public PDVector3 position;

		public float rotationY;

		public bool isFlying;
	}
}
