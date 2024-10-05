using Microsoft.EntityFrameworkCore;

namespace Desafio3.Models
{
    public class ProyectosDBContext : DbContext
    {
        public ProyectosDBContext(DbContextOptions<ProyectosDBContext> options)
        : base(options)
        {
        }

        public DbSet<EquipoT> Equipo { get; set; }
        public DbSet<ProyectoT> Proyecto { get; set; }
        public DbSet<TareaT> Tarea { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EquipoT>().HasData(
                new EquipoT { Id = 1, Nombre = "Desarrollo", Descripcion = "Equipo encargado de la programación y desarrollo de software." },
                new EquipoT { Id = 2, Nombre = "Diseño", Descripcion = "Equipo encargado del diseño gráfico y experiencia de usuario." },
                new EquipoT { Id = 3, Nombre = "Operaciones", Descripcion = "Equipo encargado de la infraestructura y soporte operativo." }
            );

            modelBuilder.Entity<ProyectoT>().HasData(
                new ProyectoT { Id = 1, Nombre = "Plataforma Interna", FechaInicio = new DateTime(2024, 1, 15), FechaFin = new DateTime(2024, 5, 30), EquipoId = 1 },
                new ProyectoT { Id = 2, Nombre = "Sistema de Automatización", FechaInicio = new DateTime(2024, 3, 1), FechaFin = new DateTime(2024, 8, 15), EquipoId = 1 },
                new ProyectoT { Id = 3, Nombre = "Migración de Plataforma", FechaInicio = new DateTime(2024, 2, 10), FechaFin = new DateTime(2024, 7, 10), EquipoId = 1 },
                new ProyectoT { Id = 4, Nombre = "Rediseño Web Corporativo", FechaInicio = new DateTime(2024, 4, 1), FechaFin = new DateTime(2024, 9, 15), EquipoId = 2 },
                new ProyectoT { Id = 5, Nombre = "Identidad Visual Nueva Marca", FechaInicio = new DateTime(2024, 2, 20), FechaFin = new DateTime(2024, 6, 30), EquipoId = 2 },
                new ProyectoT { Id = 6, Nombre = "Diseño de Aplicación Móvil", FechaInicio = new DateTime(2024, 3, 5), FechaFin = new DateTime(2024, 8, 20), EquipoId = 2 },
                new ProyectoT { Id = 7, Nombre = "Optimización de Redes", FechaInicio = new DateTime(2024, 1, 10), FechaFin = new DateTime(2024, 6, 15), EquipoId = 3 },
                new ProyectoT { Id = 8, Nombre = "Automatización de Servidores", FechaInicio = new DateTime(2024, 3, 25), FechaFin = new DateTime(2024, 7, 5), EquipoId = 3 },
                new ProyectoT { Id = 9, Nombre = "Migración de Datos a Nube", FechaInicio = new DateTime(2024, 2, 15), FechaFin = new DateTime(2024, 7, 1), EquipoId = 3 }
            );

            modelBuilder.Entity<TareaT>().HasData(
                new TareaT { Id = 1, Descripcion = "Planificación inicial", Estado = "Pendiente", ProyectoId = 1 },
                new TareaT { Id = 2, Descripcion = "Desarrollo de prototipos", Estado = "En Progreso", ProyectoId = 1 },
                new TareaT { Id = 3, Descripcion = "Implementación de módulos", Estado = "Pendiente", ProyectoId = 1 },
                new TareaT { Id = 4, Descripcion = "Pruebas de integración", Estado = "Pendiente", ProyectoId = 1 },
                new TareaT { Id = 5, Descripcion = "Despliegue inicial", Estado = "Pendiente", ProyectoId = 1 },

                new TareaT { Id = 6, Descripcion = "Recolección de requerimientos", Estado = "Pendiente", ProyectoId = 2 },
                new TareaT { Id = 7, Descripcion = "Diseño del sistema", Estado = "Pendiente", ProyectoId = 2 },
                new TareaT { Id = 8, Descripcion = "Configuración de servidores", Estado = "En Progreso", ProyectoId = 2 },
                new TareaT { Id = 9, Descripcion = "Pruebas de rendimiento", Estado = "Pendiente", ProyectoId = 2 },
                new TareaT { Id = 10, Descripcion = "Lanzamiento del sistema", Estado = "Pendiente", ProyectoId = 2 },

                new TareaT { Id = 11, Descripcion = "Evaluación de la plataforma actual", Estado = "Pendiente", ProyectoId = 3 },
                new TareaT { Id = 12, Descripcion = "Planificación de migración", Estado = "En Progreso", ProyectoId = 3 },
                new TareaT { Id = 13, Descripcion = "Implementación del nuevo sistema", Estado = "Pendiente", ProyectoId = 3 },
                new TareaT { Id = 14, Descripcion = "Transferencia de datos", Estado = "Pendiente", ProyectoId = 3 },
                new TareaT { Id = 15, Descripcion = "Pruebas finales", Estado = "Pendiente", ProyectoId = 3 },

                new TareaT { Id = 16, Descripcion = "Investigación de usuario", Estado = "Pendiente", ProyectoId = 4 },
                new TareaT { Id = 17, Descripcion = "Creación de wireframes", Estado = "Pendiente", ProyectoId = 4 },
                new TareaT { Id = 18, Descripcion = "Diseño de interfaz de usuario", Estado = "En Progreso", ProyectoId = 4 },
                new TareaT { Id = 19, Descripcion = "Implementación de prototipos", Estado = "Pendiente", ProyectoId = 4 },
                new TareaT { Id = 20, Descripcion = "Pruebas de usabilidad", Estado = "Pendiente", ProyectoId = 4 },

                new TareaT { Id = 21, Descripcion = "Desarrollo de conceptos", Estado = "Pendiente", ProyectoId = 5 },
                new TareaT { Id = 22, Descripcion = "Diseño de logo", Estado = "Pendiente", ProyectoId = 5 },
                new TareaT { Id = 23, Descripcion = "Creación de guías de estilo", Estado = "En Progreso", ProyectoId = 5 },
                new TareaT { Id = 24, Descripcion = "Elaboración de material promocional", Estado = "Pendiente", ProyectoId = 5 },
                new TareaT { Id = 25, Descripcion = "Presentación al cliente", Estado = "Pendiente", ProyectoId = 5 },

                new TareaT { Id = 26, Descripcion = "Diseño de pantallas", Estado = "Pendiente", ProyectoId = 6 },
                new TareaT { Id = 27, Descripcion = "Creación de iconografía", Estado = "Pendiente", ProyectoId = 6 },
                new TareaT { Id = 28, Descripcion = "Pruebas de diseño", Estado = "Pendiente", ProyectoId = 6 },
                new TareaT { Id = 29, Descripcion = "Adaptación a diferentes dispositivos", Estado = "En Progreso", ProyectoId = 6 },
                new TareaT { Id = 30, Descripcion = "Revisión final de diseño", Estado = "Pendiente", ProyectoId = 6 },

                new TareaT { Id = 31, Descripcion = "Auditoría de infraestructura", Estado = "Pendiente", ProyectoId = 7 },
                new TareaT { Id = 32, Descripcion = "Revisión de configuraciones actuales", Estado = "Pendiente", ProyectoId = 7 },
                new TareaT { Id = 33, Descripcion = "Implementación de mejoras", Estado = "En Progreso", ProyectoId = 7 },
                new TareaT { Id = 34, Descripcion = "Pruebas de conectividad", Estado = "Pendiente", ProyectoId = 7 },
                new TareaT { Id = 35, Descripcion = "Documentación de cambios", Estado = "Pendiente", ProyectoId = 7 },

                new TareaT { Id = 36, Descripcion = "Configuración de herramientas", Estado = "Pendiente", ProyectoId = 8 },
                new TareaT { Id = 37, Descripcion = "Desarrollo de scripts de automatización", Estado = "Pendiente", ProyectoId = 8 },
                new TareaT { Id = 38, Descripcion = "Pruebas de integración", Estado = "En Progreso", ProyectoId = 8 },
                new TareaT { Id = 39, Descripcion = "Documentación del proceso", Estado = "Pendiente", ProyectoId = 8 },
                new TareaT { Id = 40, Descripcion = "Implementación en producción", Estado = "Pendiente", ProyectoId = 8 },

                new TareaT { Id = 41, Descripcion = "Selección de plataforma", Estado = "Pendiente", ProyectoId = 9 },
                new TareaT { Id = 42, Descripcion = "Planificación de migración de datos", Estado = "En Progreso", ProyectoId = 9 },
                new TareaT { Id = 43, Descripcion = "Ejecución de la migración", Estado = "Pendiente", ProyectoId = 9 },
                new TareaT { Id = 44, Descripcion = "Pruebas post-migración", Estado = "Pendiente", ProyectoId = 9 },
                new TareaT { Id = 45, Descripcion = "Documentación de la migración", Estado = "Pendiente", ProyectoId = 9 }
        );
       }
    }
}
