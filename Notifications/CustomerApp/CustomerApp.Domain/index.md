# CustomerApp.Domain

Este proyecto contiene las clases de dominio para la aplicación de clientes.

## Características

- **Customer**: Entidad principal del cliente
- **CustomerRegistration**: Proceso de registro de clientes
- **DataAccessLayer**: Capa de acceso a datos
- **EmailService**: Servicio de envío de emails
- **Validator**: Validador de datos

## Uso

```csharp
// Ejemplo de uso
var customer = new Customer("Juan", "Pérez", "juan@email.com");
var validator = new Validator();
if (validator.ValidateCustomer(customer))
{
    // Procesar cliente válido
}
```

## API Reference

Consulte la [documentación de la API](api/) para obtener información detallada sobre todas las clases y métodos disponibles.
