using System;

namespace ClientCommon.PacketData
{
	public class PDFieldOfHonorRanking : PDRanking
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.battlePower);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.battlePower = reader.ReadInt32();
		}

		public PDFieldOfHonorRanking()
		{
		}

		public int battlePower;
	}
}
