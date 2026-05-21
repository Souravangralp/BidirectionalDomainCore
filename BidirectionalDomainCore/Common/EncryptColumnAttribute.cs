namespace Bidirectional.DomainCore.Common;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public class EncryptColumnAttribute : Attribute
{
}


//Steps for nuget updation for domain
//    Step 1 Take the latest from the main branch
//    Step 2 Open csprog file  <Version>1.1.0</Version> update the version if this commit have some minor bug fixes update the version count from second decimal, If major fixes change the version 2.0.0 
//        Step 3 Right click on project and Pack the solution
//        Step 4 Build the project it will generate the Bidirectional.DomainCore.BidOnboard.Core.1.1.0.nupkg file.
//        Step 5 Run this command with Required params " dotnet nuget push Yournuget.nupkg --api-key Your-API-KEY --source https://api.nuget.org/v3/index.json " 
//        for example dotnet nuget push C:\path\to\YourPackage.nupkg --api-key YOUR-API-KEY --source https://api.nuget.org/v3/index.json
//        Step 6 Go to nuget gallery -> manage package -> Published packages -> Select Edit button of the updated package
//        Step 7 Go to listing dropdown Select the latest version as latest and save

// dotnet nuget push "C:\path\to\YourPackage.nupkg" --api-key YOUR-API-KEY --source https://api.nuget.org/v3/index.json
