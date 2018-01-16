using System;
using ClientCommon.PacketData;

namespace ClientCommon.ClientEventBody
{
	public class CEBHeroBeginAttackEventBody : CEBClientEventBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.attackerId);
			writer.Write(this.attackMotionNo);
			writer.Write(this.position);
			writer.Write(this.rotationY);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.attackerId = reader.ReadInt32();
			this.attackMotionNo = reader.ReadInt32();
			this.position = reader.ReadPDVector3();
			this.rotationY = reader.ReadSingle();
		}

		public CEBHeroBeginAttackEventBody()
		{
		}

		public int attackerId;

		public int attackMotionNo;

		public PDVector3 position;

		public float rotationY;
	}
}
