using System;

namespace WebCommon
{
	public class WPDBeadSocketExtendRecipe : WPDPacketData
	{
		public override void Serialize(WPacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.socketId);
			writer.Write(this.unOwnDia);
		}

		public override void Deserialize(WPacketReader reader)
		{
			base.Deserialize(reader);
			this.socketId = reader.ReadInt32();
			this.unOwnDia = reader.ReadInt32();
		}

		public WPDBeadSocketExtendRecipe()
		{
		}

		public int socketId;

		public int unOwnDia;
	}
}
