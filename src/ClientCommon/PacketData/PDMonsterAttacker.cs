using System;

namespace ClientCommon.PacketData
{
	public class PDMonsterAttacker : PDAttacker
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

		public PDMonsterAttacker()
		{
		}

		public long monsterInstanceId;
	}
}
