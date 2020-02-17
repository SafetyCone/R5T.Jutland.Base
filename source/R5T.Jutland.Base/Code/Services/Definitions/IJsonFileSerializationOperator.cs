using System;


namespace R5T.Jutland
{
    public interface IJsonFileSerializationOperator
    {
        void Serialize<T>(string jsonFilePath, T value);
        T Deserialize<T>(string jsonFilePath);
    }
}
