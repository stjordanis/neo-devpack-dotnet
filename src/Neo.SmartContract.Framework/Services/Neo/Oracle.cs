#pragma warning disable CS0626

namespace Neo.SmartContract.Framework.Services.Neo
{
    [Contract("0xfe924b7cfe89ddd271abaf7210a80a7e11178758")]
    public class Oracle
    {
        public static extern UInt160 Hash { [ContractHash] get; }
        public const uint MinimumResponseFee = 0_10000000;
        public static extern void Request(string url, string filter, string callback, object userData, long gasForResponse);
    }
}

