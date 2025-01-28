namespace NBTExplorerRenew.Utils.NBT
{
    internal enum TagTypes
    {
        TAG_End = 0,
        TAG_Byte = 1,
        TAG_Short = 2,
        TAG_Int = 3,
        TAG_Long = 4,
        TAG_Float = 5,
        TAG_Double = 6,
        TAG_ByteArray = 7,
        TAG_String = 8,
        TAG_List = 9,
        TAG_Compound = 10,
        TAG_IntArray = 11,
        TAG_LongArray = 12
    }

    internal class Tag
    {
        public TagTypes Type;
        public object? Payload;

        public Tag(TagTypes type, object? payload)
        {
            Type = type;
            Payload = payload;
        }

        public Tag(TagTypes type)
        {
            Type = type;
        }
    }
}
