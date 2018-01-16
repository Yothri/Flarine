using System;

namespace WebCommon
{
	public class WPDTradeShipObject : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.tradition);
			writer.Write(this.objectId);
			writer.Write(this.monsterId);
			writer.Write(this.xPosition);
			writer.Write(this.yPosition);
			writer.Write(this.zPosition);
			writer.Write(this.stepId);
			writer.Write(this.hitMessageDisplayable);
			writer.Write(this.hitMessageDisplayInterval);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.tradition = reader.ReadInt32();
			this.objectId = reader.ReadInt32();
			this.monsterId = reader.ReadInt32();
			this.xPosition = reader.ReadDouble();
			this.yPosition = reader.ReadDouble();
			this.zPosition = reader.ReadDouble();
			this.stepId = reader.ReadInt32();
			this.hitMessageDisplayable = reader.ReadBoolean();
			this.hitMessageDisplayInterval = reader.ReadInt32();
		}

		public WPDTradeShipObject()
		{
		}

		public int tradition;

		public int objectId;

		public int monsterId;

		public double xPosition;

		public double yPosition;

		public double zPosition;

		public int stepId;

		public bool hitMessageDisplayable;

		public int hitMessageDisplayInterval;
	}
}
