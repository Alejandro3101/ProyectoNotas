using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Proyecto.Models
    {
   
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<Nota> Nota { get; set; }

    }

    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public ICollection<Nota> IdNota { get; set; }



    }

    public class Materia
    {
        public int Id{ get; set; }
        public string NombreMateria { get; set; }
        public ICollection<Nota> IdNota { get; set; }

    }

    public class Nota
    {
        public int Id { get; set; }
        public string Notas { get; set; }

      public Materia Materia { set; get; }
        public Alumno Alumno { set; get; }

        public int AlumnoId { get; set; }
        public int MateriaId { get; set; }



    }

}
