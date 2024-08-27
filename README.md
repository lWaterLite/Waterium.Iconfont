# Waterium.Iconfont

[![Waterium.Iconfont](https://img.shields.io/badge/Waterium.Iconfont-%40lWaterLite-blue)](https://github.com/lWaterLite) [![.Net](https://img.shields.io/badge/.NET-8.0-green)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

Waterium.Iconfont is an iconfont library for WPF desktop application.

## Install

1. Download the [Latest release](https://github.com/lWaterLite/Waterium.Iconfont/release), and unzip it at any directory you like.
2. Open your own project, and add reference to the `.dll` file.
3. References should be solved by your using IDE.

## Usage

In your `App.xaml` file, add a namespace as following

```xaml
xmlns:wtr="clr-namespace:Waterium.Iconfont.SystemIconfont;assembly=Waterium.Iconfont.SystemIconfont
```

Notice that `SystemIconfont` should be replaced by the correct library you are using.

Then in your window, you can add the control

```xaml
<wtr:SystemIconfont Icon="Love" FontSize="64" Foreground="Aqua" />
```

The control is inherited from original WPF `TextBlock` control, so it can just be used as a `TextBlock`.

Followings are the available library

- SystemIconfont

## License

[MIT](LICENSE) @ 2024 lWaterLite