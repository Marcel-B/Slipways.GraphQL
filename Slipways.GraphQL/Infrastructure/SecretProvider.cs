using com.b_velop.Slipways.GrQl.Contracts;
using Microsoft.Extensions.FileProviders;
using System;
using System.IO;

namespace com.b_velop.Slipways.GrQl.Infrastructure
{
    public class SecretProvider : ISecretProvider
    {
        public string GetSecret(
            string key)
        {
            const string DOCKER_SECRET_PATH = "/run/secrets/";
            if (Directory.Exists(DOCKER_SECRET_PATH))
            {
                using var provider = new PhysicalFileProvider(DOCKER_SECRET_PATH);
                var fileInfo = provider.GetFileInfo(key);
                if (fileInfo.Exists)
                {
                    using var stream = fileInfo.CreateReadStream();
                    using var streamReader = new StreamReader(stream);
                    return streamReader.ReadToEnd();
                }
            }
            return Environment.GetEnvironmentVariable(key);
        }
    }
}
