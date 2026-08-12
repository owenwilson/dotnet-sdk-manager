# MiniApiConsole

## create proyect

- create folder

```sh
mkdir MiniApiConsole
```

- check out specify version

```sh
dotnet --list-sdks
8.0.424 [/home/user/.dotnet/sdk]
10.0.400 [/home/user/.dotnet/sdk]
```

- specify the dotnet(.net) version

```sh
dotnet new globaljson --sdk-version 8.0.424
```

- verify json file

```sh
cat global.json
{
  "sdk": {
    "version": "8.0.424"
  }
}
```

- init proyect

```sh
dotnet new console
```
