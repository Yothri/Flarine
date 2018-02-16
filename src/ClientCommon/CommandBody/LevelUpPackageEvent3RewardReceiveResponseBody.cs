using System;

namespace ClientCommon.CommandBody
{
	public class LevelUpPackageEvent3RewardReceiveResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dia);
			writer.Write(this.ownDia);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.dia = reader.ReadInt32();
			this.ownDia = reader.ReadInt32();
		}

		public LevelUpPackageEvent3RewardReceiveResponseBody()
		{
		}

		public int dia;

		public int ownDia;
	}
}
