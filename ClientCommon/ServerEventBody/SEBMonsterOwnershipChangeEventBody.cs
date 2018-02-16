using System;

namespace ClientCommon.ServerEventBody
{
	public class SEBMonsterOwnershipChangeEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterInstanceId);
			writer.Write(this.ownerId);
			writer.WriteEnumInt<MonsterOwnerType>(this.ownerType);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterInstanceId = reader.ReadInt64();
			this.ownerId = reader.ReadInt32();
			this.ownerType = reader.ReadEnumInt<MonsterOwnerType>();
		}

		public SEBMonsterOwnershipChangeEventBody()
		{
		}

		public long monsterInstanceId;

		public int ownerId;

		public MonsterOwnerType ownerType;
	}
}
