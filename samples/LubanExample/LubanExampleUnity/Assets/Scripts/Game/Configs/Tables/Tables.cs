
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


public partial class Tables
{
    public Examples.TbBasicConfig TbBasicConfig {get; }
    public Examples.TbAdavancedConfig TbAdavancedConfig {get; }
    public Examples.TbGlobalConfig TbGlobalConfig {get; }
    public Examples.TbListConfig TbListConfig {get; }

    public Tables(System.Func<string, ByteBuf> loader)
    {
        TbBasicConfig = new Examples.TbBasicConfig(loader("examples_tbbasicconfig"));
        TbAdavancedConfig = new Examples.TbAdavancedConfig(loader("examples_tbadavancedconfig"));
        TbGlobalConfig = new Examples.TbGlobalConfig(loader("examples_tbglobalconfig"));
        TbListConfig = new Examples.TbListConfig(loader("examples_tblistconfig"));
        ResolveRef();
    }
    
    private void ResolveRef()
    {
        TbBasicConfig.ResolveRef(this);
        TbAdavancedConfig.ResolveRef(this);
        TbGlobalConfig.ResolveRef(this);
        TbListConfig.ResolveRef(this);
    }
}


