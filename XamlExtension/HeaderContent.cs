namespace XamlExtension;

public class HeaderContent : ContentControl
{
    public const string ElementGrid = "PART_Grid";
    public const string ElementContentPresenter = "PART_ContentPresenter";
    public const string ElementHeaderContentPresenter = "PART_HeaderContentPresenter";

    public static readonly StyledProperty<object> HeaderProperty =
        AvaloniaProperty.Register<HeaderContent, object>(nameof(Header));

    public static readonly StyledProperty<IDataTemplate> HeaderTemplateProperty =
        AvaloniaProperty.Register<HeaderContent, IDataTemplate>(nameof(HeaderTemplate));

    public static readonly StyledProperty<HorizontalAlignment> HorizontalHeaderAlignmentProperty =
        AvaloniaProperty.Register<HeaderContent, HorizontalAlignment>(nameof(HorizontalHeaderAlignment));

    public static readonly StyledProperty<VerticalAlignment> VerticalHeaderAlignmentProperty =
        AvaloniaProperty.Register<HeaderContent, VerticalAlignment>(nameof(VerticalHeaderAlignment));

    public object Header
    {
        get => GetValue(HeaderProperty);
        set => SetValue(HeaderProperty, value);
    }

    public IDataTemplate HeaderTemplate
    {
        get => GetValue(HeaderTemplateProperty);
        set => SetValue(HeaderTemplateProperty, value);
    }

    public HorizontalAlignment HorizontalHeaderAlignment
    {
        get => GetValue(HorizontalHeaderAlignmentProperty);
        set => SetValue(HorizontalHeaderAlignmentProperty, value);
    }

    public VerticalAlignment VerticalHeaderAlignment
    {
        get => GetValue(VerticalHeaderAlignmentProperty);
        set => SetValue(VerticalHeaderAlignmentProperty, value);
    }
}