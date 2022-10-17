﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Security.Policy;

namespace API_Copa_do_Mundo_2022.Models
{
    [Table("partidas_clubes")]
    [Keyless]
    [Index(nameof(PartidaId), IsUnique = true)]
    public class PartidaClube
    {
        [Required]
        [Column(name: "partidas_id")]
        public int PartidaId { get; set; }
        public Partida Partida { get; set; }

        [Required]
        [Column(name: "clubes_id_a")]
        public int ClubeIdA { get; set; }
        public virtual Clube ClubeA { get; set; }

        [Required]
        [Column(name: "clubes_id_b")]
        public int ClubeIdB { get; set; }
        public virtual Clube ClubeB { get; set; }
    }
}