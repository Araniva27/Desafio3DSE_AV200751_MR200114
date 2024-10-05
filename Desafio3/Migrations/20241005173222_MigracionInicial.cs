using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Desafio3.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proyecto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EquipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyecto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proyecto_Equipo_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ProyectoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarea_Proyecto_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "Proyecto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Equipo",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Equipo encargado de la programación y desarrollo de software.", "Desarrollo" },
                    { 2, "Equipo encargado del diseño gráfico y experiencia de usuario.", "Diseño" },
                    { 3, "Equipo encargado de la infraestructura y soporte operativo.", "Operaciones" }
                });

            migrationBuilder.InsertData(
                table: "Proyecto",
                columns: new[] { "Id", "EquipoId", "FechaFin", "FechaInicio", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plataforma Interna" },
                    { 2, 1, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sistema de Automatización" },
                    { 3, 1, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Migración de Plataforma" },
                    { 4, 2, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rediseño Web Corporativo" },
                    { 5, 2, new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Identidad Visual Nueva Marca" },
                    { 6, 2, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diseño de Aplicación Móvil" },
                    { 7, 3, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Optimización de Redes" },
                    { 8, 3, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Automatización de Servidores" },
                    { 9, 3, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Migración de Datos a Nube" }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "Id", "Descripcion", "Estado", "ProyectoId" },
                values: new object[,]
                {
                    { 1, "Planificación inicial", "Pendiente", 1 },
                    { 2, "Desarrollo de prototipos", "En Progreso", 1 },
                    { 3, "Implementación de módulos", "Pendiente", 1 },
                    { 4, "Pruebas de integración", "Pendiente", 1 },
                    { 5, "Despliegue inicial", "Pendiente", 1 },
                    { 6, "Recolección de requerimientos", "Pendiente", 2 },
                    { 7, "Diseño del sistema", "Pendiente", 2 },
                    { 8, "Configuración de servidores", "En Progreso", 2 },
                    { 9, "Pruebas de rendimiento", "Pendiente", 2 },
                    { 10, "Lanzamiento del sistema", "Pendiente", 2 },
                    { 11, "Evaluación de la plataforma actual", "Pendiente", 3 },
                    { 12, "Planificación de migración", "En Progreso", 3 },
                    { 13, "Implementación del nuevo sistema", "Pendiente", 3 },
                    { 14, "Transferencia de datos", "Pendiente", 3 },
                    { 15, "Pruebas finales", "Pendiente", 3 },
                    { 16, "Investigación de usuario", "Pendiente", 4 },
                    { 17, "Creación de wireframes", "Pendiente", 4 },
                    { 18, "Diseño de interfaz de usuario", "En Progreso", 4 },
                    { 19, "Implementación de prototipos", "Pendiente", 4 },
                    { 20, "Pruebas de usabilidad", "Pendiente", 4 },
                    { 21, "Desarrollo de conceptos", "Pendiente", 5 },
                    { 22, "Diseño de logo", "Pendiente", 5 },
                    { 23, "Creación de guías de estilo", "En Progreso", 5 },
                    { 24, "Elaboración de material promocional", "Pendiente", 5 },
                    { 25, "Presentación al cliente", "Pendiente", 5 },
                    { 26, "Diseño de pantallas", "Pendiente", 6 },
                    { 27, "Creación de iconografía", "Pendiente", 6 },
                    { 28, "Pruebas de diseño", "Pendiente", 6 },
                    { 29, "Adaptación a diferentes dispositivos", "En Progreso", 6 },
                    { 30, "Revisión final de diseño", "Pendiente", 6 },
                    { 31, "Auditoría de infraestructura", "Pendiente", 7 },
                    { 32, "Revisión de configuraciones actuales", "Pendiente", 7 },
                    { 33, "Implementación de mejoras", "En Progreso", 7 },
                    { 34, "Pruebas de conectividad", "Pendiente", 7 },
                    { 35, "Documentación de cambios", "Pendiente", 7 },
                    { 36, "Configuración de herramientas", "Pendiente", 8 },
                    { 37, "Desarrollo de scripts de automatización", "Pendiente", 8 },
                    { 38, "Pruebas de integración", "En Progreso", 8 },
                    { 39, "Documentación del proceso", "Pendiente", 8 },
                    { 40, "Implementación en producción", "Pendiente", 8 },
                    { 41, "Selección de plataforma", "Pendiente", 9 },
                    { 42, "Planificación de migración de datos", "En Progreso", 9 },
                    { 43, "Ejecución de la migración", "Pendiente", 9 },
                    { 44, "Pruebas post-migración", "Pendiente", 9 },
                    { 45, "Documentación de la migración", "Pendiente", 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proyecto_EquipoId",
                table: "Proyecto",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_ProyectoId",
                table: "Tarea",
                column: "ProyectoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Proyecto");

            migrationBuilder.DropTable(
                name: "Equipo");
        }
    }
}
