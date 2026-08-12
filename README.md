# dotnet-sdk-manager

# install dotnet script

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

## references

- check out [dotnet install script](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-install-script)
- check out [linux scripted manual](https://learn.microsoft.com/en-us/dotnet/core/install/linux-scripted-manual#scripted-install)
