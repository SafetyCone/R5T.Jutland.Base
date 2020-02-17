using System;


namespace R5T.Jutland
{
    public interface IJsonStringSerializationOperator
    {
        string Serialize<T>(T value);
        T Deserialize<T>(string json);
    }
}
