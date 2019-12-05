namespace com.b_velop.Slipways.GrQl.Infrastructure
{
    public interface ISecretProvider
    {
        string GetSecret(string key);
    }
}