# 1 - `.csproj` Contents

The `.csproj` file contains the **project configuration and settings**.

```xml
<Project Sdk="Microsoft.NET.Sdk">

    <PropertyGroup>
        <OutputType>Exe</OutputType>
        <TargetFramework>net10.0</TargetFramework>
        <ImplicitUsings>enable</ImplicitUsings>
        <Nullable>enable</Nullable>
    </PropertyGroup>

</Project>
```

### 2. Do `#region / #endregion` change the compiled output? Why might you still use them?

`#region / #endregion` do not change the compiled output. We use them to organize and group related code, especially when refactoring is not available.

### 3. When would you reach for `///` XML doc comments instead of a plain `//`?

We use `//` for regular comments, while `///` is used to document methods for developers.

### 4. Why does C# have no true global variables, and what's the closest equivalent?

C# has no true global variables because variables must belong to a type or a scope. A `static` field inside a class is the closest equivalent.




