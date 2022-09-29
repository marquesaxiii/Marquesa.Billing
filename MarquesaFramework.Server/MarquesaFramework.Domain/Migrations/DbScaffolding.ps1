dotnet ef dbcontext scaffold "Host=localhost;Database=MarquesaSystems;Username=postgres;Password=postgres" Npgsql.EntityFrameworkCore.PostgreSQL -o DataTransferObjects -f --project ../MarquesaFramework.Domain.csproj

pause