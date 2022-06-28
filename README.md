# PackagesBugDemo

This is a sample application showcasing an issue I'm currently having with a WPF application that uses the Microsoft.NET.Sdk.Web SDK.

More info: (https://developercommunity.visualstudio.com/t/Package-dependencies-disappear-on-build/10074434?space=8&entry=problem)[https://developercommunity.visualstudio.com/t/Package-dependencies-disappear-on-build/10074434?space=8&entry=problem]

## Reproduce

1. Clone this repo
2. Open the solution in VS2022 (latest 17.2.5 or 17.3.0 Preview 2.0)
3. Press F5 to debug - everything should build and run without issue
4. Stop debugging
5. Rebuild the solution/project from the Solution Explorer
6. Observe red squiggles for NLog's LogManager in `app.xaml.cs` and errors in the Error List.

## Things I've tried

1. Restarting VS2022
2. Restarting computer
3. Deleting .vs folder
4. Deleting bin and obj folders
5. Using another computer (tried on 3 of my own PCs and several colleagues have the same issue with our application)
