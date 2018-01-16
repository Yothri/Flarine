using System;

namespace ClientCommon.PacketData
{
	public abstract class PDAttacker : PDPacketData
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

		public static PDAttacker Create(int nType)
		{
			switch (nType)
			{
			case 1:
				return new PDHeroAttacker();
			case 2:
				return new PDMonsterAttacker();
			default:
				return null;
			}
		}

		protected PDAttacker()
		{
		}

		public const int kType_Hero = 1;

		public const int kType_Monster = 2;
	}
}
