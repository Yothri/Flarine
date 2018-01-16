using System;

namespace ClientCommon.PacketData
{
	public abstract class PDMonsterInstance : PDPacketData
	{
		public abstract int instanceType { get; }

		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.instanceType);
			writer.Write(this.instanceId);
			writer.Write(this.monsterCharacterId);
			writer.Write(this.monsterId);
			writer.Write(this.nameKey);
			writer.Write(this.hpRecovery);
			writer.Write(this.attackSpeed);
			writer.Write(this.moveSpeed);
			writer.Write(this.visibilityDistance);
			writer.Write(this.attackRange);
			writer.Write(this.hitRange);
			writer.Write(this.scale);
			writer.Write(this.level);
			writer.Write(this.maxHP);
			writer.Write(this.hp);
			writer.Write(this.skillId);
			writer.Write(this.abnormalStateEffects);
			writer.Write(this.spawnedPosition);
			writer.Write(this.spawnedRotationY);
			writer.Write(this.position);
			writer.Write(this.rotationY);
			writer.Write(this.ownerId);
			writer.WriteEnumInt<MonsterOwnerType>(this.ownerType);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.instanceId = reader.ReadInt64();
			this.monsterCharacterId = reader.ReadInt32();
			this.monsterId = reader.ReadInt32();
			this.nameKey = reader.ReadString();
			this.hpRecovery = reader.ReadInt32();
			this.attackSpeed = reader.ReadSingle();
			this.moveSpeed = reader.ReadSingle();
			this.visibilityDistance = reader.ReadSingle();
			this.attackRange = reader.ReadSingle();
			this.hitRange = reader.ReadSingle();
			this.scale = reader.ReadSingle();
			this.level = reader.ReadInt32();
			this.maxHP = reader.ReadInt32();
			this.hp = reader.ReadInt32();
			this.skillId = reader.ReadInt32();
			this.abnormalStateEffects = reader.ReadPDPacketDatas<PDAbnormalStateEffect>();
			this.spawnedPosition = reader.ReadPDVector3();
			this.spawnedRotationY = reader.ReadSingle();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
			this.ownerId = reader.ReadInt32();
			this.ownerType = reader.ReadEnumInt<MonsterOwnerType>();
		}

		public static PDMonsterInstance Create(int nType)
		{
			if (nType <= 71)
			{
				if (nType <= 30)
				{
					switch (nType)
					{
					case 10:
						return new PDContinentMonsterInstance();
					case 11:
						return new PDContinentBossMonsterInstance();
					default:
						if (nType == 20)
						{
							return new PDStoryDungeonMonsterInstance();
						}
						if (nType == 30)
						{
							return new PDExpDungeonMonsterInstance();
						}
						break;
					}
				}
				else if (nType <= 50)
				{
					if (nType == 40)
					{
						return new PDGoldDungeonMonsterInstance();
					}
					if (nType == 50)
					{
						return new PDCursedDockMonsterInstance();
					}
				}
				else
				{
					if (nType == 60)
					{
						return new PDAnkouTombMonsterInstance();
					}
					switch (nType)
					{
					case 70:
						return new PDTradeShipMonsterInstance();
					case 71:
						return new PDTradeShipObjectInstance();
					}
				}
			}
			else if (nType <= 100)
			{
				switch (nType)
				{
				case 80:
					return new PDBossAnnihilationMonsterInstance();
				case 81:
					return new PDBossAnnihilationSummonMonsterInstance();
				default:
					if (nType == 90)
					{
						return new PDActualTrainingMonsterInstance();
					}
					if (nType == 100)
					{
						return new PDAbyssTowerMonsterInstance();
					}
					break;
				}
			}
			else if (nType <= 122)
			{
				switch (nType)
				{
				case 110:
					return new PDGuildDungeonMonsterInstance();
				case 111:
					return new PDGuildDungeonSummonMonsterInstance();
				default:
					switch (nType)
					{
					case 120:
						return new PDFallenCityNormalMonsterInstance();
					case 121:
						return new PDFallenCityHiddenBossMonsterInstance();
					case 122:
						return new PDFallenCityBossMonsterInstance();
					}
					break;
				}
			}
			else
			{
				if (nType == 130)
				{
					return new PDSecretChamberMonsterInstance();
				}
				if (nType == 140)
				{
					return new PDSkyDungeonMonsterInstance();
				}
			}
			return null;
		}

		protected PDMonsterInstance()
		{
		}

		public long instanceId;

		public int monsterCharacterId;

		public int monsterId;

		public string nameKey;

		public int hpRecovery;

		public float attackSpeed;

		public float moveSpeed;

		public float visibilityDistance;

		public float attackRange;

		public float hitRange;

		public float scale;

		public int level;

		public int maxHP;

		public int hp;

		public int skillId;

		public PDAbnormalStateEffect[] abnormalStateEffects;

		public PDVector3 spawnedPosition;

		public float spawnedRotationY;

		public PDVector3 position;

		public float rotationY;

		public int ownerId;

		public MonsterOwnerType ownerType;
	}
}
