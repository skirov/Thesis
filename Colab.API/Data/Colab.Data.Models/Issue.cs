﻿namespace Colab.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Colab.Data.Contracts;

    public class Issue : AuditInfo
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Status { get; set; }

        public string Priority { get; set; }

        public int TeamId { get; set; }

        public int AssigneeId { get; set; }

        public int ReporterId { get; set; }

        public virtual Team Team { get; set; }

        public virtual User Assignee { get; set; }

        public virtual User Reporter { get; set; }
    }
}
