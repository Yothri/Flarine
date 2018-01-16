using System;

namespace ClientCommon.CommandBody
{
	public class SetStatAutoDistributionCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.statAutoDistribution);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.statAutoDistribution = reader.ReadBoolean();
		}

		public SetStatAutoDistributionCommandBody()
		{
		}

		public bool statAutoDistribution;
	}
}
