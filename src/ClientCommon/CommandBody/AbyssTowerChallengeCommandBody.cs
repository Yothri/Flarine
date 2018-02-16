using System;

namespace ClientCommon.CommandBody
{
	public class AbyssTowerChallengeCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.targetFloor);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.targetFloor = reader.ReadInt32();
		}

		public AbyssTowerChallengeCommandBody()
		{
		}

		public int targetFloor;
	}
}
