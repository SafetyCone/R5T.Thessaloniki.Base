using System;using R5T.T0064;


namespace R5T.Thessaloniki
{[ServiceDefinitionMarker]
    public interface ITemporaryDirectoryPathProvider:IServiceDefinition
    {
        string GetTemporaryDirectoryPath();
    }
}
