using System;
using ClientCommon.PacketData;

namespace ClientCommon.CommandBody
{
	public class InstantRevivalResponseBody : ResponseBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.date);
			writer.Write(this.hp);
			writer.Write(this.position);
			writer.Write(this.rotationY);
			writer.Write(this.revivalInvincibilityRemainingTime);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.date = reader.ReadDateTime();
			this.hp = reader.ReadInt32();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
			this.revivalInvincibilityRemainingTime = reader.ReadSingle();
		}

		public InstantRevivalResponseBody()
		{
		}

		public DateTime date;

		public int hp;

		public PDVector3 position;

		public float rotationY;

		public float revivalInvincibilityRemainingTime;
	}
}
