# Problema 29: Control de acceso a la sede

Autoriza a `admin` a cualquier hora, a `instructor` entre las 6 y las 21 horas y a `aprendiz` entre las 6 y las 18 horas. Los roles no registrados y horarios fuera de esos intervalos se deniegan.

## Ejecución

```powershell
dotnet run --project Problema29/Problema29.csproj
```

## Evidencias

Guarda las capturas de ejecución en [evidencias/](./evidencias/).