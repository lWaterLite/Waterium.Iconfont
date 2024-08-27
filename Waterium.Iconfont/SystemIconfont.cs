using System.Windows;
using System.Windows.Controls;

namespace Waterium.Iconfont;

public class SystemIconfont : TextBlock
{
    public enum SystemIconfontType
    {
        Close,
        Minimize,
        Maximize,
        MaximizeFill,
        Setting,
        SettingFill,
        Search,
        Love,
        Home,
        About,
        More,
    }

    private static readonly Dictionary<SystemIconfontType, string> IconTypeResourceMap =
        new()
        {
            { SystemIconfontType.Close, "Close" },
            { SystemIconfontType.Minimize, "Minimize" },
            { SystemIconfontType.Maximize, "Maximize" },
            { SystemIconfontType.MaximizeFill, "MaximizeFill" },
            { SystemIconfontType.Setting, "Setting" },
            { SystemIconfontType.SettingFill, "SettingFill" },
            { SystemIconfontType.Search, "Search" },
            { SystemIconfontType.Love, "Love" },
            { SystemIconfontType.Home, "Home" },
            { SystemIconfontType.More, "More" },
            { SystemIconfontType.About, "About" },
        };

    static SystemIconfont()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(SystemIconfont),
            new FrameworkPropertyMetadata(typeof(SystemIconfont)));
    }

    #region Icon

    public static readonly DependencyProperty SystemIconTypeProperty = DependencyProperty.Register(nameof(Icon),
        typeof(SystemIconfontType), typeof(SystemIconfont), new PropertyMetadata(OnIconChanged));

    private static void OnIconChanged(DependencyObject d, DependencyPropertyChangedEventArgs _)
    {
        SystemIconfont? control = d as SystemIconfont;
        control?.UpdateText();
    }

    public SystemIconfontType Icon
    {
        get => (SystemIconfontType)GetValue(SystemIconTypeProperty);
        set => SetValue(SystemIconTypeProperty, value);
    }

    private void UpdateText()
    {
        ResourceDictionary resourceDictionary = new()
        {
            Source = new Uri("/Waterium.Iconfont;component/Themes/Generic.xaml", UriKind.Relative)
        };
        if (IconTypeResourceMap.TryGetValue(Icon, out string? resourceKey))
        {
            Text = resourceDictionary[resourceKey] as string ?? "&#xe661;";
        }
        else
        {
            Text = "&#xe661;";
        }
    }

    #endregion
}