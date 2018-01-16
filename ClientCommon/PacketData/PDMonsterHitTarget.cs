using System;

namespace ClientCommon.PacketData
{
	public class PDMonsterHitTarget : PDHitTarget
	{
		public override int type
		{
			get
			{
				return 2;
			}
		}

		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.monsterInstanceId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.monsterInstanceId = reader.ReadInt64();
		}

		public PDMonsterHitTarget()
		{
		}

		public long monsterInstanceId;
	}
}
