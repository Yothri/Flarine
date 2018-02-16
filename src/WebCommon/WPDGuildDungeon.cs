using System;

namespace WebCommon
{
	public class WPDGuildDungeon : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.dungeonId);
			writer.Write(this.sceneName);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.startRadius);
			writer.Write(this.spawnMonsterId);
			writer.Write(this.locationId);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.dungeonId = reader.ReadInt32();
			this.sceneName = reader.ReadString();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.startRadius = reader.ReadDouble();
			this.spawnMonsterId = reader.ReadInt32();
			this.locationId = reader.ReadInt32();
		}

		public WPDGuildDungeon()
		{
		}

		public int dungeonId;

		public string sceneName;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public double startRadius;

		public int spawnMonsterId;

		public int locationId;
	}
}
