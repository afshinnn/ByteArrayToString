namespace ByteArrayToString
{
    class Message
    {
        /// <summary>
        /// Message object
        /// <paramref name="_Data"/>: data array
        /// </summary>
        public Message(byte[] _Data) => Data = _Data;

        /// <summary>
        /// Encapsulated data
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// String represenataion of data
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Join(",", Data);
        }
    }
}
