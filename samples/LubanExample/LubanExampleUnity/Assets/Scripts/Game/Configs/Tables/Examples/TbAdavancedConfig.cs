
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace Examples
{
public partial class TbAdavancedConfig
{
    private readonly System.Collections.Generic.List<Examples.AdavancedConfig> _dataList;


    public TbAdavancedConfig(ByteBuf _buf)
    {
        _dataList = new System.Collections.Generic.List<Examples.AdavancedConfig>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Examples.AdavancedConfig _v;
            _v = Examples.AdavancedConfig.DeserializeAdavancedConfig(_buf);
            _dataList.Add(_v);
        }
    }

    public System.Collections.Generic.List<Examples.AdavancedConfig> DataList => _dataList;

    
    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }
}

}

