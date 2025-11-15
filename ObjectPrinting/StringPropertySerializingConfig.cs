namespace ObjectPrinting;

public class StringPropertySerializingConfig<TOwner> : PropertySerializingConfig<TOwner, string>
{
    public StringPropertySerializingConfig(PrintingConfig<TOwner> printingConfig, string propertyName) 
        : base(printingConfig, propertyName) { }

    public PrintingConfig<TOwner> TrimTo(int maxLength)
    {
        printingConfig.AddPropertyTrim(propertyName, maxLength);
        return printingConfig;
    }
}