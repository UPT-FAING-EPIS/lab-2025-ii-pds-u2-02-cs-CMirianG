# Configuración de GitHub Pages

Para configurar GitHub Pages para la documentación generada por DocFx:

## Pasos de configuración:

1. **Habilitar GitHub Pages en el repositorio:**
   - Ve a Settings > Pages en tu repositorio de GitHub
   - Selecciona "GitHub Actions" como fuente
   - El workflow `publish_docs.yml` se encargará de publicar automáticamente

2. **Configurar permisos:**
   - Ve a Settings > Actions > General
   - En "Workflow permissions", selecciona "Read and write permissions"
   - Marca "Allow GitHub Actions to create and approve pull requests"

3. **URLs de documentación:**
   - Notifications.Domain: `https://cmiriang.github.io/lab-2025-ii-pds-u2-02-cs-CMirianG/notifications-domain/`
   - CustomerApp.Domain: `https://cmiriang.github.io/lab-2025-ii-pds-u2-02-cs-CMirianG/customerapp-domain/`

## Configuración adicional requerida:

### SonarCloud
1. Crear cuenta en [SonarCloud](https://sonarcloud.io)
2. Crear proyecto para el repositorio
3. Generar token de SonarCloud
4. Agregar `SONAR_TOKEN` a los secrets del repositorio

### GitHub Packages
1. Los paquetes NuGet se publicarán automáticamente en GitHub Packages
2. URL: `https://github.com/CMirianG/lab-2025-ii-pds-u2-02-cs-CMirianG/packages`

### Codecov (opcional)
1. Conectar repositorio con [Codecov](https://codecov.io)
2. El workflow ya está configurado para enviar reportes de cobertura
