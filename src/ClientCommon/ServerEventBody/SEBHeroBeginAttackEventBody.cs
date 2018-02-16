using System;
using ClientCommon.PacketData;

namespace ClientCommon.ServerEventBody
{
	public class SEBHeroBeginAttackEventBody : SEBServerEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.accountHeroId);
			writer.Write(this.attackMotionNo);
			writer.Write(this.position);
			writer.Write(this.rotationY);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.accountHeroId = reader.ReadInt32();
			this.attackMotionNo = reader.ReadInt32();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
		}

		public SEBHeroBeginAttackEventBody()
		{
		}

		public int accountHeroId;

		public int attackMotionNo;

		public PDVector3 position;

		public float rotationY;
	}
}
