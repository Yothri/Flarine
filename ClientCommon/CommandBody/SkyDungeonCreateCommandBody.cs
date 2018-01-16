using System;

namespace ClientCommon.CommandBody
{
	public class SkyDungeonCreateCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dungeonId);
			writer.Write(this.requiredBattlePower);
			writer.Write(this.autoStart);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.dungeonId = reader.ReadInt32();
			this.requiredBattlePower = reader.ReadInt32();
			this.autoStart = reader.ReadBoolean();
		}

		public SkyDungeonCreateCommandBody()
		{
		}

		public int dungeonId;

		public int requiredBattlePower;

		public bool autoStart;
	}
}
