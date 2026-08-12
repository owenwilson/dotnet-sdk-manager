# dotnet-sdk-manager

# install dotnet script

- current os fedora

```sh
curl -L https://dot.net/v1/dotnet-install.sh -o dotnet-install.sh
```

```sh
chmod +x ./dotnet-install.sh
```

```sh
./dotnet-install.sh --version latest
```

- add environment variable

```sh
export DOTNET_ROOT=$HOME/.dotnet
export PATH=$PATH:$DOTNET_ROOT:$DOTNET_ROOT/tools
```

## change version

- after installation, the dotnet settings folder is located in the home foler

```sh
ls -l ~/.dotnet/sdk
```

- or use the following command

```sh
dotnet --list-sdks
8.0.424 [/home/user/.dotnet/sdk]
10.0.400 [/home/user/.dotnet/sdk]
```

- change to dotnet 8.0.424

```sh
mkdir my-proyect
```

```sh
dotnet new globaljson --sdk-version 8.0.424
```

```sh
dotnet --version
8.0.424
```

```sh
dotnet new console
```

## references

- check out [dotnet install script](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-install-script)
- check out [linux scripted manual](https://learn.microsoft.com/en-us/dotnet/core/install/linux-scripted-manual#scripted-install)
- check out [dotnet linux debian](https://learn.microsoft.com/en-us/dotnet/core/install/linux-debian?source=recommendations)
- check out [uninstall dotnet](https://learn.microsoft.com/en-us/dotnet/core/install/remove-runtime-sdk-versions?pivots=os-linux#scripted-or-manual)
