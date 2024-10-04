
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
public partial class TbGlobalConfig
{

     private readonly Examples.GlobalConfig _data;

     public Examples.GlobalConfig Data => _data;

    public TbGlobalConfig(ByteBuf _buf)
    {
        int n = _buf.ReadSize();
        if (n != 1) throw new SerializationException("table mode=one, but size != 1");
        _data = Examples.GlobalConfig.DeserializeGlobalConfig(_buf);
    }


    /// <summary>
    /// 新手商店优惠次数
    /// </summary>
     public int NewbieDiscountTimes => _data.NewbieDiscountTimes;
    /// <summary>
    /// 单日好感度增加上限
    /// </summary>
     public float AffectionIncrementLimit => _data.AffectionIncrementLimit;
    /// <summary>
    /// 礼物冷却时间
    /// </summary>
     public long GiftCooldown => _data.GiftCooldown;
    
    public void ResolveRef(Tables tables)
    {
        _data.ResolveRef(tables);
    }
}

}

