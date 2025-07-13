using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationWebPortal.Models;

namespace DL_JobApplicationWebPortal.DL_Model
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<AdminDetails> AdminDetails { get; set; }
        //public DbSet<CandidateDetails> CandidateDetails { get; set; }
       // public DbSet<JobDetails> JobDetails { get; set; }
        //public DbSet<InterviewDetails> InterviewDetails { get; set; }
    }
    
}
