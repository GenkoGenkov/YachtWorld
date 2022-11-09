﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YachtWorld.Infrastructure.Data
{
    public class Shipyard
    {
        public Shipyard()
        {
            Yachts = new List<Yacht>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Location { get; set; } = null!;

        public int? EstablishedIn { get; set; }

        [Required]
        public int YachtId { get; set; }

        [ForeignKey(nameof(YachtId))]
        public Yacht Yacht { get; set; } = null!;

        public List<Yacht> Yachts { get; set; }
    }
}
