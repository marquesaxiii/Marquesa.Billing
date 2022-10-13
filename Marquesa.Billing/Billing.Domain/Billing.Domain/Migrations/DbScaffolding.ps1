dotnet ef dbcontext scaffold "Host=localhost;Database=MarquesaBilling;Username=postgres;Password=postgres" Npgsql.EntityFrameworkCore.PostgreSQL -o DataTransferObjects -f --project ../Billing.Domain.csproj -- schema "Water"

pause