using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBMonsterBeginAttackEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterInstanceId);
			writer.Write(this.attackMotionNo);
			writer.Write(this.position);
			writer.Write(this.rotationY);
			writer.Write(this.accountHeroId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterInstanceId = reader.ReadInt64();
			this.attackMotionNo = reader.ReadInt32();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
			this.accountHeroId = reader.ReadInt32();
		}

		public SEBMonsterBeginAttackEventBody()
		{
		}

		public long monsterInstanceId;

		public int attackMotionNo;

		public PDVector3 position;

		public float rotationY;

		public int accountHeroId;
	}
}
