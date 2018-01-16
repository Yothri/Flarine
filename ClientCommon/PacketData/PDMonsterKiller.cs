using System;

namespace ClientCommon.PacketData
{
	public class PDMonsterKiller : PDKiller
	{
		public PDMonsterKiller() : this(0L, 0)
		{
		}

		public PDMonsterKiller(long lnInstanceId, int nMonsterId)
		{
			this.instanceId = lnInstanceId;
			this.monsterId = nMonsterId;
		}

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
			writer.Write(this.instanceId);
			writer.Write(this.monsterId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.instanceId = reader.ReadInt64();
			this.monsterId = reader.ReadInt32();
		}

		public long instanceId;

		public int monsterId;
	}
}
