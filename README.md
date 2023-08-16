# LeftPad

A NuGet Package that pads strings on the left.

Port of [leftpad](https://github.com/left-pad/left-pad/blob/master/index.js)

## Using a Local NuGet Server

This repo is just used as a demo of creating a local NuGet server for test purposes. You can manage NuGet package sources in Visual Studio or from the `dotnet` CLI. Here are some example commands:

```bash
dotnet nuget add source c:\LocalNuget -n LocalNuget
```

**NOTE:** This will fail if the path already exists, so you can't point multiple sources to the same location even if they have different names.

List all sources:

```bash
dotnet nuget list source
```

Enable or disable a source by name:

```bash
dotnet nuget enable source LocalNuget
dotnet nuget disable source LocalNuget
```

Remove a source entirely:

```bash
dotnet nuget remove source LocalNuget
```

## Creating and Publishing a Simple NuGet Package

See the [docs](https://learn.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli).

Modify the .csproj file to add NuGet specific properties. (see [Ardalis.LeftPad.csproj](Ardalis.LeftPad/Ardalis.LeftPad.csproj))

For production releaes of packages you should always specify the Release configuration.

From the CLI:

```bash
dotnet pack -c Release
```

You can add `-o [path]` to control where the output goes. For instance, `-o .` will output the nupkg file in the current directory.

Publish to your LocalNuGet folder (either may work):

```bash
dotnet nuget push -o c:\LocalNuget
dotnet nuget add New.Package.1.0.0.nupkg -source LocalNuget
```

Note that your local package source should use a hierarchical folder structure. [See local feeds docs](https://learn.microsoft.com/en-us/nuget/hosting-packages/local-feeds) for more info and utilities to create the structure.

