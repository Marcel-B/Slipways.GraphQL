namespace com.b_velop.Slipways.GrQl.Contracts
{
    public interface ISecretProvider
    {
        string GetSecret(string key);
    }
}