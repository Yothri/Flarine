using System;

namespace ClientCommon.CommandBody
{
	public class CompleteLandingResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.fp);
			writer.Write(this.realMoveSpeed);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.fp = reader.ReadInt32();
			this.realMoveSpeed = reader.ReadSingle();
		}

		public CompleteLandingResponseBody()
		{
		}

		public int fp;

		public float realMoveSpeed;
	}
}
