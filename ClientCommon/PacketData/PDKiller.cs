using System;

namespace ClientCommon.PacketData
{
	public abstract class PDKiller : PDPacketData
	{
		public abstract int type { get; }

		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.type);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
		}

		public static PDKiller Create(int nType)
		{
			switch (nType)
			{
			case 1:
				return new PDHeroKiller();
			case 2:
				return new PDMonsterKiller();
			default:
				return null;
			}
		}

		protected PDKiller()
		{
		}

		public const int kType_Hero = 1;

		public const int kType_Monster = 2;
	}
}
