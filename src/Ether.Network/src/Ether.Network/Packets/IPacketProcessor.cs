namespace Ether.Network.Packets
{
    /// <summary>
    /// Defines the behavior of a <see cref="IPacketProcessor"/>.
    /// </summary>
    public interface IPacketProcessor
    {
        /// <summary>
        /// Gets the packet header size.
        /// </summary>
        int HeaderSize { get; }
        
        /// <summary>
        /// Gets a value indicating whether to put the packet header in front of the packet <see cref="INetPacketStream.Buffer"/>.
        /// </summary>
        bool IncludeHeader { get; }

        /// <summary>
        /// Gets the packet length.
        /// </summary>
        /// <param name="buffer">Input buffer</param>
        /// <returns>Packet data length</returns>
        int GetLength(byte[] buffer);

        /// <summary>
        /// Creates a T packet instance.
        /// </summary>
        /// <param name="buffer">Input buffer</param>
        /// <returns></returns>
        INetPacketStream CreatePacket(byte[] buffer);
    }
}
