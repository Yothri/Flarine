using System;

namespace ClientCommon.PacketData
{
	public class PDHeroHitTarget : PDHitTarget
	{
		public override int type
		{
			get
			{
				return 1;
			}
		}

		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
		}

		public PDHeroHitTarget()
		{
		}

		public int accountHeroId;
	}
}
