#!/usr/bin/env bash
dotnet restore SamDotNet
dotnet build SamDotNet
dotnet restore SamDotNet.Tests
dotnet build SamDotNet.Tests
dotnet test SamDotNet.Tests/SamDotNet.Tests.csproj
