<p align="center">
  <img src="https://i.ibb.co/mFFY6Gn2/N-i-dung-o-n-v-n-b-n-c-a-b-n-removebg-preview-1.png" alt="FastStrap">
</p>

<p align="center">
  A third-party Roblox bootstrapper with performance features, forked from <a href="https://github.com/bloxstraplabs/bloxstrap">Bloxstrap</a>.
</p>

<div align="center">



</div>

---

FastStrap is a fork of [Bloxstrap](https://github.com/bloxstraplabs/bloxstrap) by [pizzaboxer](https://github.com/pizzaboxer), maintained by **FastWind**. It replaces the standard Roblox bootstrapper and adds extra performance and customization options.

FastStrap is only supported on **Windows**.

---

## Features

- **High process priority** — Launch Roblox with high CPU priority to improve frame times and reduce stutters
- **Close background apps** — Free up RAM and CPU by closing other apps before Roblox launches
- **Cloudflare DNS (1.1.1.1)** — Switch to Cloudflare DNS when launching Roblox for faster lookups
- **Discord Rich Presence** — Let your friends see what you're playing at a glance
- **Mod support** — Customize content files (death sound, cursor, etc.)
- **Fast Flags manager** — Configure Roblox graphics and UI settings
- **Server location** — See where your game server is 
- **Server Region** — Choose server the game for ping slow

---

## Installing

1. Download the [latest release](https://github.com/FastWind/FastStrap/releases/latest) and run `FastStrap.exe`
2. Choose your install location and preferences, then click **Install**
3. FastStrap will be added to your Start Menu and Desktop

> **Note:** You need the [.NET 6 Desktop Runtime](https://aka.ms/dotnet-core-applaunch?missing_runtime=true&arch=x64&rid=win11-x64&apphost_version=6.0.16&gui=true). If it's missing, you'll be prompted to install it automatically.

> **Windows SmartScreen:** If a popup appears on first run, click **More info → Run anyway**. This happens because the app is new, not because it's malicious.

---

## Building from source

Requirements: [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload, and .NET 6 SDK.

```
git clone https://github.com/FastWind/FastStrap
cd FastStrap
dotnet build FastStrap/FastStrap.csproj
```

---

## Credits

- **FastStrap** is maintained by [FastWind](https://github.com/nthung-bot)
- **Bloxstrap** (original project) was created by [pizzaboxer](https://github.com/pizzaboxer) and the [bloxstraplabs](https://github.com/bloxstraplabs) team
- UI library: [bloxstraplabs/wpfui](https://github.com/bloxstraplabs/wpfui) (fork of [lepoco/wpfui](https://github.com/lepoco/wpfui))

This project is licensed under the [MIT License](LICENSE).
