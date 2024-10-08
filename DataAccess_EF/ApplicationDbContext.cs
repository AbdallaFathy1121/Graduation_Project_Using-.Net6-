﻿using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_EF
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<TbContact> TbContacts { get; set; }
        public DbSet<TbSpecialization> TbSpecialization { get; set; }
        public DbSet<TbDoctor> TbDoctors { get; set; }
        public DbSet<TbClinicImage> TbClinicImages { get; set; }
        public DbSet<TbDiseaseType> TbDiseaseTypes { get; set; }
        public DbSet<TbDisease> TbDiseases { get; set; }
        public DbSet<TbAdvice> TbAdvices { get; set; }
        public DbSet<TbComment> TbComments { get; set; }
        public DbSet<TbReplay> TbReplays { get; set; }
        public DbSet<TbDoctorViewsCount> TbDoctorViewsCounts { get; set; }
        public DbSet<TbRating> TbRatings { get; set; }
        public DbSet<TdRegistrationRequests> TdRegistrationRequests { get; set; }
        public DbSet<TbAdviceRequest> TbAdviceRequests { get; set; }
        public DbSet<TbPneumonia> TbPneumonias { get; set; }
        public DbSet<TbTuberculosis> TbTuberculosis { get; set; }
        public DbSet<TbLungCancer> TbLungCancer { get; set; }
        public DbSet<TbMeasuringBox> TbMeasuringBox { get; set; }
        public DbSet<TbLungTransplant> TbLungTransplants { get; set; }
        public DbSet<TbLungAnalysisFile> TbLungAnalysisFile { get; set; }

    }
}
