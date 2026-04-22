

@echo off
setlocal enabledelayedexpansion

:: Obtener timestamp AAAAMMDDhhmmss
for /f %%a in ('wmic os get localdatetime ^| find "."') do set dt=%%a
set timestamp=%dt:~0,4%%dt:~4,2%%dt:~6,2%%dt:~8,2%%dt:~10,2%%dt:~12,2%

:: Nombre base para la migraci n (pod s cambiarlo)
set migrationName=AutoMigration_DemoUNLZ

set context=AppDbContext

:: Ruta relativa del proyecto donde est  el DbContext
set project=Web

:: Ruta relativa del proyecto startup (donde est  Program.cs)
set startup=Web

:: Directorio donde se guardan las migraciones
set outputDir=Data/Migrations/DbContext



echo === Generando migraciones para todos los DbContexts ===

dotnet ef migrations add %migrationName%_%timestamp% --context %context% --output-dir %outputDir% --project %project% --startup-project %startup%

echo === Aplicando migraciones ===

dotnet ef database update --context %context% --project %project% --startup-project %startup%

echo === Listo! ===
pause