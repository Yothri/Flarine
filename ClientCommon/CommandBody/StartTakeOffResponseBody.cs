using System;

namespace ClientCommon.CommandBody
{
	public class StartTakeOffResponseBody : ResponseBody
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

		public StartTakeOffResponseBody()
		{
		}

		public int fp;

		public float realMoveSpeed;
	}
}
