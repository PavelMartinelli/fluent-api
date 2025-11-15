using System;
using System.Globalization;

namespace ObjectPrinting;

public class TypeSerializingConfig<TOwner, TType>
{
    private readonly PrintingConfig<TOwner> printingConfig;

    public TypeSerializingConfig(PrintingConfig<TOwner> printingConfig)
    {
        this.printingConfig = printingConfig;
    }
    
    public PrintingConfig<TOwner> Use(Func<TType, string> serializeFunc)
    {
        printingConfig.AddTypeSerializer(serializeFunc);
        return printingConfig;
    }

    public PrintingConfig<TOwner> Use(CultureInfo cultureInfo)
    {
        printingConfig.AddTypeCulture<TType>(cultureInfo);
        return printingConfig;
    }
}