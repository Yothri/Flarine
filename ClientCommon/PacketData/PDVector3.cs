using System;

namespace ClientCommon.PacketData
{
	public struct PDVector3
	{
		public PDVector3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public float x;

		public float y;

		public float z;
	}
}
