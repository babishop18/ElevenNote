using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevenNote.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElevenNote.Data
{
    public class ElevenNoteDbContext : DbContext
    {
        public ElevenNoteDbContext(DbContextOptions<ElevenNoteDbContext> options) : base(options)
        {}

        public DbSet<UserEntity> Users { get; set; }
    }
}