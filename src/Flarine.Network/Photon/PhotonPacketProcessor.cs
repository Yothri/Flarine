using Ether.Network.Packets;
using Flarine.Network.Photon.IO.Protocol;

namespace Flarine.Network.Photon
{
    internal sealed class PhotonPacketProcessor : IPacketProcessor
    {
        public int HeaderSize => 5;
        public bool IncludeHeader => true;

        public int GetLength(byte[] buffer)
        {
            if (buffer[0] == 240)
                return HeaderSize;

            int offset = 1;
            var len = 0;
            Protocol.Deserialize(out len, buffer, ref offset);
            return len;
        }

        public INetPacketStream CreatePacket(byte[] buffer)
        {
            return new NetPacket(buffer);
        }
    }
}