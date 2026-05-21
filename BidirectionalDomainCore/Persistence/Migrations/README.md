# Platform migrations (single folder)

All EF Core migrations for the unified `ApplicationDbContext` live here.

- **One** `ApplicationDbContext` maps entities from every module.
- **Multiple** SQL schemas per module (`loan`, `onboarding`, `calculator`, `postcode`, `productmatrix`, `common`) via `EntitySchemaConvention`.

## Add a migration (from DomainCore project directory)

```bash
dotnet ef migrations add <MigrationName> \
  --project BidirectionalDomainCore.csproj \
  --context ApplicationDbContext \
  --output-dir Persistence/Migrations
```

## Apply

```bash
dotnet ef database update \
  --project BidirectionalDomainCore.csproj \
  --context ApplicationDbContext
```

### Package Manager Console

Set **Default project** to `BidirectionalDomainCore` (or **Startup project** to `Bidirectional.WebUI` if you prefer that `appsettings`).

```powershell
Update-Database -Context ApplicationDbContext -Project BidirectionalDomainCore
```

If you see **certificate chain is not trusted**, ensure the connection string includes:

`Encrypt=True;TrustServerCertificate=True`

(for local SQL Express / dev only). The DomainCore `appsettings.json` and `ApplicationDbContextFactory` apply this for design-time when the keyword is missing.

Legacy per-repo `Infrastructure/Data/Migrations` folders should not receive new migrations once modules are wired to this context.
