using System;

namespace ClientCommon.CommandBody
{
	public class FallenCityCreateCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.requiredBattlePower);
			writer.Write(this.autoStart);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.requiredBattlePower = reader.ReadInt32();
			this.autoStart = reader.ReadBoolean();
		}

		public FallenCityCreateCommandBody()
		{
		}

		public int requiredBattlePower;

		public bool autoStart;
	}
}
