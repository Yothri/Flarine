using System;

namespace WebCommon
{
	public class WPDSecretChamberFloor : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.floor);
			writer.Write(this.name);
			writer.Write(this.nameKey);
			writer.Write(this.sceneName);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.startRadius);
			writer.Write(this.monsterId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.floor = reader.ReadInt32();
			this.name = reader.ReadString();
			this.nameKey = reader.ReadString();
			this.sceneName = reader.ReadString();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.startRadius = reader.ReadDouble();
			this.monsterId = reader.ReadInt32();
		}

		public WPDSecretChamberFloor()
		{
		}

		public int floor;

		public string name;

		public string nameKey;

		public string sceneName;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public double startRadius;

		public int monsterId;
	}
}
