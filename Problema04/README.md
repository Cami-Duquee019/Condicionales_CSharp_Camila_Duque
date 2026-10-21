# Problema 4: Alerta de batería

Lee el nivel de batería. Si es menor que 15 %, muestra `Batería baja: conecte el cargador`; siempre termina mostrando `Nivel actual: X %`.

## Ejecución

```powershell
dotnet run --project Problema04/Problema04.csproj
```

Ejemplo: `10` muestra la alerta y `Nivel actual: 10 %`; `80` solo muestra el nivel.

## Evidencias

Guarda las capturas de ejecución en [evidencias/](./evidencias/).