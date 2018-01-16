using System;

namespace ClientCommon.CommandBody
{
	public class SetPvpModeCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.pvpModeId);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.pvpModeId = reader.ReadInt32();
		}

		public SetPvpModeCommandBody()
		{
		}

		public int pvpModeId;
	}
}
