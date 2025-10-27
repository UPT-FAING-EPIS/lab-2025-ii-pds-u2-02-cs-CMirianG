# Notifications.Domain

Este proyecto contiene las clases de dominio para el sistema de notificaciones.

## Características

- **AbstractMessage**: Clase base abstracta para mensajes
- **EmailMessageSender**: Implementación para envío de emails
- **SmsMessageSender**: Implementación para envío de SMS
- **LongMessage**: Implementación para mensajes largos
- **ShortMessage**: Implementación para mensajes cortos

## Uso

```csharp
// Ejemplo de uso
var emailSender = new EmailMessageSender();
var message = new LongMessage("Contenido del mensaje");
emailSender.SendMessage(message);
```

## API Reference

Consulte la [documentación de la API](api/) para obtener información detallada sobre todas las clases y métodos disponibles.
