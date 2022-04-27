using System;

using R5T.T0064;


namespace R5T.Jutland
{
    [ServiceDefinitionMarker]
    public interface IJsonStringSerializationOperator : IServiceDefinition
    {
        string Serialize<T>(T value);
        T Deserialize<T>(string json);
    }
}
