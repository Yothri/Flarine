using System;

namespace WebCommon
{
	public class WPDAbyssTowerFloor : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.floor);
			writer.Write(this.sceneName);
			writer.Write(this.recommendPower);
			writer.Write(this.clearOwnGold);
			writer.Write(this.clearStarEssense);
			writer.Write(this.clearItemId);
			writer.Write(this.clearItemCount);
			writer.Write(this.sweepOwnGold);
			writer.Write(this.sweepStarEssense);
			writer.Write(this.sweepItemId);
			writer.Write(this.sweepItemCount);
			writer.Write(this.startXPosition);
			writer.Write(this.startYPosition);
			writer.Write(this.startZPosition);
			writer.Write(this.spawnXPosition);
			writer.Write(this.spawnYPosition);
			writer.Write(this.spawnZPosition);
			writer.Write(this.spawnRadius);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.floor = reader.ReadInt32();
			this.sceneName = reader.ReadString();
			this.recommendPower = reader.ReadInt32();
			this.clearOwnGold = reader.ReadInt32();
			this.clearStarEssense = reader.ReadInt32();
			this.clearItemId = reader.ReadInt32();
			this.clearItemCount = reader.ReadInt32();
			this.sweepOwnGold = reader.ReadInt32();
			this.sweepStarEssense = reader.ReadInt32();
			this.sweepItemId = reader.ReadInt32();
			this.sweepItemCount = reader.ReadInt32();
			this.startXPosition = reader.ReadDouble();
			this.startYPosition = reader.ReadDouble();
			this.startZPosition = reader.ReadDouble();
			this.spawnXPosition = reader.ReadDouble();
			this.spawnYPosition = reader.ReadDouble();
			this.spawnZPosition = reader.ReadDouble();
			this.spawnRadius = reader.ReadDouble();
		}

		public WPDAbyssTowerFloor()
		{
		}

		public int floor;

		public string sceneName;

		public int recommendPower;

		public int clearOwnGold;

		public int clearStarEssense;

		public int clearItemId;

		public int clearItemCount;

		public int sweepOwnGold;

		public int sweepStarEssense;

		public int sweepItemId;

		public int sweepItemCount;

		public double startXPosition;

		public double startYPosition;

		public double startZPosition;

		public double spawnXPosition;

		public double spawnYPosition;

		public double spawnZPosition;

		public double spawnRadius;
	}
}
