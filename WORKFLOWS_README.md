# Workflows de Automatización

Este repositorio incluye tres workflows de GitHub Actions para automatizar la documentación, pruebas, análisis de código y publicación de paquetes.

## 📋 Workflows Implementados

### 1. 📚 Publish Documentation (`publish_docs.yml`)
**Propósito:** Generar y publicar documentación automática usando DocFx

**Triggers:**
- Push a la rama `main`
- Pull requests a la rama `main`

**Funcionalidades:**
- ✅ Genera documentación API usando DocFx
- ✅ Publica en GitHub Pages automáticamente
- ✅ Documentación para ambos proyectos: Notifications.Domain y CustomerApp.Domain

**URLs de documentación:**
- Notifications.Domain: `https://cmiriang.github.io/lab-2025-ii-pds-u2-02-cs-CMirianG/notifications-domain/`
- CustomerApp.Domain: `https://cmiriang.github.io/lab-2025-ii-pds-u2-02-cs-CMirianG/customerapp-domain/`

### 2. 🧪 Package NuGet (`package_nuget.yml`)
**Propósito:** Ejecutar pruebas, análisis de código y publicar paquetes NuGet

**Triggers:**
- Push a las ramas `main` y `develop`
- Pull requests a la rama `main`

**Funcionalidades:**
- ✅ Ejecuta pruebas unitarias con reportes
- ✅ Análisis de código con SonarCloud
- ✅ Genera paquetes NuGet (.nupkg)
- ✅ Publica paquetes en GitHub Packages
- ✅ Reportes de cobertura de código

**Secrets requeridos:**
- `SONAR_TOKEN`: Token de SonarCloud

### 3. 🚀 Release Version (`release_version.yml`)
**Propósito:** Crear releases versionados y publicar en GitHub Releases

**Triggers:**
- Push de tags con formato `v*` (ej: `v1.0.0`)
- Ejecución manual con parámetros

**Funcionalidades:**
- ✅ Crea releases en GitHub Releases
- ✅ Incluye paquetes NuGet como assets
- ✅ Publica paquetes en GitHub Packages
- ✅ Ejecuta pruebas antes del release

## 🛠️ Configuración Requerida

### 1. GitHub Pages
```bash
# En Settings > Pages del repositorio:
Source: GitHub Actions
```

### 2. SonarCloud
1. Crear cuenta en [SonarCloud](https://sonarcloud.io)
2. Crear proyecto para el repositorio
3. Generar token de SonarCloud
4. Agregar `SONAR_TOKEN` a los secrets del repositorio

### 3. Permisos del Repositorio
```bash
# En Settings > Actions > General:
Workflow permissions: Read and write permissions
Allow GitHub Actions to create and approve pull requests: ✅
```

## 📦 Estructura de Paquetes

Los workflows generan los siguientes paquetes NuGet:

- **Notifications.Domain**: Biblioteca de dominio para notificaciones
- **CustomerApp.Domain**: Biblioteca de dominio para aplicación de clientes

## 🚀 Cómo Usar

### Crear un Release
```bash
# Crear y push un tag
git tag v1.0.0
git push origin v1.0.0

# O usar la ejecución manual desde GitHub Actions
```

### Verificar Documentación
Después de hacer push a `main`, la documentación se actualiza automáticamente en GitHub Pages.

### Monitorear Análisis
Los reportes de SonarCloud y cobertura de código se generan en cada push/PR.

## 📁 Archivos Creados

```
.github/workflows/
├── publish_docs.yml      # Workflow de documentación
├── package_nuget.yml     # Workflow de paquetes y pruebas
└── release_version.yml   # Workflow de releases

Notifications/
├── Notifications.Domain/
│   ├── docfx.json        # Configuración DocFx
│   ├── toc.yml           # Tabla de contenidos
│   └── index.md          # Página principal
└── CustomerApp/
    └── CustomerApp.Domain/
        ├── docfx.json    # Configuración DocFx
        ├── toc.yml       # Tabla de contenidos
        └── index.md       # Página principal

GITHUB_PAGES_SETUP.md     # Guía de configuración
```

## ✅ Estado de Implementación

- [x] Workflow de documentación con DocFx
- [x] Workflow de pruebas y SonarCloud
- [x] Workflow de releases
- [x] Configuración DocFx para ambos proyectos
- [x] Documentación de configuración

## 🔧 Troubleshooting

### Error de permisos
- Verificar que los permisos de GitHub Actions estén configurados correctamente

### Error de SonarCloud
- Verificar que el token `SONAR_TOKEN` esté configurado en los secrets

### Error de GitHub Pages
- Verificar que GitHub Pages esté habilitado con fuente "GitHub Actions"

### Error de paquetes NuGet
- Verificar que el token `GITHUB_TOKEN` tenga permisos de escritura
