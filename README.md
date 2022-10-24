# FSharp
F# scripts

## Simple

 dotnet publish -c Release -r win10-x64 -p:PublishTrimmed=true --self-contained

## Explicit (with osx target)

dotnet publish \
  --framework net6.0 \
  --runtime osx-x64 \
  --self-contained true \
  -p:PublishSingleFile=true \
  -p:IncludeNativeLibrariesForSelfExtract=true \
  -p:PublishTrimmed=true \
  -p:PublishReadyToRun=true \
  -p:EnableCompressionInSingleFile=true \
  -p:DebugType=embedded \
  -p:ServerGarbageCollection=true \
  --output dist
