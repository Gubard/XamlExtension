namespace XamlExtension;

public static partial class HeaderContentExtension
{
    public static THeaderContent SetHeader<THeaderContent>(this THeaderContent headerContent, object header)
        where THeaderContent : HeaderContent
    {
        headerContent.Header = header;
        return headerContent;
    }

    public static THeaderContent SetHeaderTemplate<THeaderContent>(this THeaderContent headerContent,
        IDataTemplate headerTemplate) where THeaderContent : HeaderContent
    {
        headerContent.HeaderTemplate = headerTemplate;
        return headerContent;
    }

    public static THeaderContent SetHorizontalHeaderAlignment<THeaderContent>(this THeaderContent headerContent,
        HorizontalAlignment horizontalHeaderAlignment) where THeaderContent : HeaderContent
    {
        headerContent.HorizontalHeaderAlignment = horizontalHeaderAlignment;
        return headerContent;
    }

    public static THeaderContent SetVerticalHeaderAlignment<THeaderContent>(this THeaderContent headerContent,
        VerticalAlignment verticalHeaderAlignment) where THeaderContent : HeaderContent
    {
        headerContent.VerticalHeaderAlignment = verticalHeaderAlignment;
        return headerContent;
    }
}