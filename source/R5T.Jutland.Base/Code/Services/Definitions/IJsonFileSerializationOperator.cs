using System;

using R5T.T0064;


namespace R5T.Jutland
{
    [ServiceDefinitionMarker]
    public interface IJsonFileSerializationOperator : IServiceDefinition
    {
        void Serialize<T>(string jsonFilePath, T value);
        T Deserialize<T>(string jsonFilePath);
    }
}
