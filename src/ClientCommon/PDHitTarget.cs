using System;
using ClientCommon.PacketData;

namespace ClientCommon
{
	public abstract class PDHitTarget : PDPacketData
	{
		public abstract int type { get; }

		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.type);
			writer.Write(this.position);
			writer.Write(this.rotationY);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
		}

		public static PDHitTarget Create(int nType)
		{
			switch (nType)
			{
			case 1:
				return new PDHeroHitTarget();
			case 2:
				return new PDMonsterHitTarget();
			default:
				return null;
			}
		}

		protected PDHitTarget()
		{
		}

		public const int kType_Hero = 1;

		public const int kType_Monster = 2;

		public PDVector3 position;

		public float rotationY;
	}
}
