using System;

namespace ClientCommon.CommandBody
{
	public class TestCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
		}

		public TestCommandBody()
		{
		}
	}
}
