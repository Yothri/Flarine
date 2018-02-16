using System.IO;

namespace Ether.Network.Packets
{
    /// <summary>
    /// Represents a Ehter.Network built-in packet.
    /// </summary>
    public sealed class NetPacket : NetPacketStream
    {
        /// <summary>
        /// Gets the packet buffer.
        /// </summary>
        public override byte[] Buffer => this.BuildBuffer();

        /// <summary>
        /// Creates a new NetPacket in write-only mode.
        /// </summary>
        public NetPacket()
        {
            this.Write(0); // Packet size
        }

        /// <summary>
        /// Creates a new NetPacket in read-only mode.
        /// </summary>
        /// <param name="buffer"></param>
        public NetPacket(byte[] buffer)
            : base(buffer)
        {
        }

        /// <summary>
        /// Builds the final buffer.
        /// </summary>
        /// <returns></returns>
        private byte[] BuildBuffer()
        {
            long oldPosition = this.Position;

            this.Seek(0, SeekOrigin.Begin);
            this.Write(this.Size);
            this.Seek((int)oldPosition, SeekOrigin.Begin);

            return base.Buffer;
        }
    }
}
