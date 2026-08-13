# MiniApiConsole

## structure proyect

```sh
MiniSln/
├── global.json
├── MiniSln.sln
├── README.md
├── src
│   └── MiniApiConsole
│       ├── MiniApiConsole.csproj
│       └── Program.cs
└── tests
    └── MiniApiConsole.Tests
        ├── MiniApiConsole.Tests.csproj
        └── UnitTest1.cs
```

## create proyect

- create folder

```sh
mkdir MiniSln
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
mkdir -p src/MiniApiConsole
dotnet new console
```

- configure tests

```sh
cd MiniSln
dotnet new sln
dotnet sln add src/MiniApiConsole/MiniApiConsole.csproj
```

```sh
cd tests/
dotnet new xunit -n MiniApiConsole.Tests
cd ..
```

```sh
dotnet sln add tests/MiniApiConsole.Tests/MiniApiConsole.Tests.csproj
cd tests/MiniApiConsole.Tests/
dotnet add reference ../../src/MiniApiConsole/MiniApiConsole.csproj
cd ../../
```

```sh
dotnet sln add tests/MiniApiConsole.Tests/MiniApiConsole.Tests.csproj
dotnet clean
rm -rf ./src/MiniApiConsole/bin/
rm -rf ./src/MiniApiConsole/obj/
rm -rf ./tests/MiniApiConsole.Tests/obj/
```

```sh
dotnet restore
dotnet build
dotnet test
```

## run example

- restore

```sh
cd ./src/MiniApiConsole
dotnet restore
```

- build

```sh
dotnet build
```

- run

```sh
dotnet run
```

- test endpoint

```sh
curl -X GET http://localhost:5000/hello/myuser
```

## xunit

- localhost

```sh
dotnet nuget locals all --clear
```

- add dependencie

```sh
cd tests/MiniApiConsole.Tests
```

```sh
dotnet add package Microsoft.AspNetCore.Mvc.Testing --version 8.0.8
```

```sh
dotnet clean
dotnet restore --verbosity detailed
dotnet build
dotnet test
```
