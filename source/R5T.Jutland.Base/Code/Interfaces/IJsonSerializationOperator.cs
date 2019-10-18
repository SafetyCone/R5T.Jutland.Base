using System;


namespace R5T.Jutland
{
    public interface IJsonSerializationOperator
    {
        void Serialize<T>(string jsonFilePath, T value);
        T Deserialize<T>(string jsonFilePath);
    }
}
