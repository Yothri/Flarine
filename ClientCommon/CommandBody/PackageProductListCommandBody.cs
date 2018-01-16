using System;

namespace ClientCommon.CommandBody
{
	public class PackageProductListCommandBody : CommandBody
	{
		public override void Serialize(PacketWriter writer)
		{
			base.Serialize(writer);
			writer.Write(this.storeType);
		}

		public override void Deserialize(PacketReader reader)
		{
			base.Deserialize(reader);
			this.storeType = reader.ReadInt32();
		}

		public PackageProductListCommandBody()
		{
		}

		public int storeType;
	}
}
