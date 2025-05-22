using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DL
{
    public partial class zirChemedContext : DbContext
    {
        public zirChemedContext()
        {
        }

        public zirChemedContext(DbContextOptions<zirChemedContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClinicVisits> ClinicVisits { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Insemination> Insemination { get; set; }
        public virtual DbSet<Iui> Iui { get; set; }
        public virtual DbSet<Pct> Pct { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<Sa> Sa { get; set; }
        public virtual DbSet<Subsidization> Subsidization { get; set; }
        public virtual DbSet<Treatments> Treatments { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Data Source=tigris.nethost.co.il,3433;Initial Catalog=zirchemedclinic;user id=zirChemedClinic;password=zirChemedClinic123  ; Integrated Security=True;pooling=False; MultipleActiveResultSets=True");
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-KPG42DB\\SQLEXPRESS;Initial Catalog=zirChemed;Integrated Security=True;pooling=False; MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClinicVisits>(entity =>
            {
                entity.Property(e => e.ClinicVisitsId).HasColumnName("clinicVisitsID");

                entity.Property(e => e.Co).HasColumnName("CO");

                entity.Property(e => e.Doctor).HasColumnName("doctor");

                entity.Property(e => e.PaymentMethod)
                    .HasColumnName("paymentMethod")
                    .HasMaxLength(255);

                entity.Property(e => e.PersonsId).HasColumnName("personsId");

                entity.Property(e => e.Preformed).HasColumnName("preformed");

                entity.Property(e => e.Morphology).HasColumnName("morphology");

                entity.Property(e => e.Receipt).HasColumnName("receipt");
                entity.Property(e => e.Closed).HasColumnName("closed");
                 entity.Property(e => e.ClosedSA).HasColumnName("closedSA");
            entity.Property(e => e.ClosedIUI).HasColumnName("closedIUI");
                entity.Property(e => e.Done).HasColumnName("done");

                entity.Property(e => e.DoneDoctor).HasColumnName("doneDoctor");

                entity.Property(e => e.DoneMorphology).HasColumnName("doneMorphology");
                entity.Property(e => e.DidNotArrive).HasColumnName("didNotArrive");
                
            entity.Property(e => e.ApartmentHr).HasColumnName("apartmentHr");
            entity.Property(e => e.ApartmentVy).HasColumnName("apartmentVy");
            entity.Property(e => e.ApartmentYy).HasColumnName("apartmentYy");

        entity.Property(e => e.TreatmentsId).HasColumnName("treatmentsId");

                entity.Property(e => e.SubsidizationApprove).HasColumnName("subsidizationApprove");

                entity.Property(e => e.SubsidizationAmount)
             .HasColumnName("subsidizationAmount")
             .HasMaxLength(255);

                entity.Property(e => e.CheckNumber)
.HasColumnName("checkNumber")
.HasMaxLength(255);

                entity.HasOne(d => d.DoctorNavigation)
                    .WithMany(p => p.ClinicVisitsDoctorNavigation)
                    .HasForeignKey(d => d.Doctor)
                    .HasConstraintName("FK_DoctorEmployees");

                entity.HasOne(d => d.Persons)
                    .WithMany(p => p.ClinicVisits)
                    .HasForeignKey(d => d.PersonsId)
                    .HasConstraintName("FK_Persons");

                entity.HasOne(d => d.PreformedNavigation)
                    .WithMany(p => p.ClinicVisitsPreformedNavigation)
                    .HasForeignKey(d => d.Preformed)
                    .HasConstraintName("FK_PreformedEmployees");

                entity.HasOne(d => d.MorphologyNavigation)
                    .WithMany(p => p.ClinicVisitsMorphologyNavigation)
                    .HasForeignKey(d => d.Morphology)
                    .HasConstraintName("FK_MorphologyEmployees");

                entity.HasOne(d => d.Treatments)
                    .WithMany(p => p.ClinicVisits)
                    .HasForeignKey(d => d.TreatmentsId)
                    .HasConstraintName("FK_Treatments");
                entity.Property(e => e.VisitsDate)
                   .HasColumnName("visitsDate")
                   .HasColumnType("dateTime");
                entity.Property(e => e.VisitTime)
                 .HasColumnName("visitTime");

            //    entity.Property(e => e.Status).HasColumnName("status");
                entity.Property(e => e.Status)
                      .HasColumnName("status")
                      .HasDefaultValue(1);
                entity.Property(e => e.Signature)
                .HasColumnName("signature")
                .HasColumnType("VARCHAR(MAX)");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK_Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.Degree)
                    .HasColumnName("degree")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorLicenseNumber).HasColumnName("doctorLicenseNumber");

                entity.Property(e => e.LicenseNumber).HasColumnName("licenseNumber");

                entity.Property(e => e.SpecializedLicenseNumber).HasColumnName("specializedLicenseNumber");

                entity.Property(e => e.PaymentForSA).HasColumnName("paymentForSA");

                entity.Property(e => e.PaymentForIUI).HasColumnName("paymentForIUI");

                entity.Property(e => e.PaymentForPCT).HasColumnName("paymentForPCT");

                entity.Property(e => e.PaymentForInsemination).HasColumnName("paymentForInsemination");

                entity.Property(e => e.PaymentForWash).HasColumnName("paymentForWash");

                entity.Property(e => e.PaymentForConsulting).HasColumnName("paymentForConsulting");

                entity.Property(e => e.PaymentForIUISA).HasColumnName("paymentForIUISA");

                entity.Property(e => e.PaymentForcanNotBeMadeIUI).HasColumnName("paymentForcanNotBeMadeIUI");

                entity.Property(e => e.PaymentForCanNotBeMadeSA).HasColumnName("paymentForCanNotBeMadeSA");

                entity.Property(e => e.PaymentForMorphology).HasColumnName("paymentForMorphology");
                


        entity.Property(e => e.EmployeEemail)
                    .HasColumnName("employeEemail")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeIdNumber).HasColumnName("employeeIdNumber");
                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employeeName")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeePassword)
                    .HasColumnName("employeePassword")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeePermission).HasColumnName("employeePermission");

                entity.Property(e => e.EmployeePhone)
                    .HasColumnName("employeePhone")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Insemination>(entity =>
            {
                entity.Property(e => e.InseminationId).HasColumnName("InseminationID");

                entity.Property(e => e.ClinicVisitsId).HasColumnName("clinicVisitsId");

                entity.Property(e => e.DoctorLicenseNumber).HasColumnName("doctorLicenseNumber");

                entity.Property(e => e.DoctorSignature).HasColumnName("doctorSignature");

                entity.Property(e => e.DoctorSignatureAfter).HasColumnName("doctorSignatureAfter");

                entity.Property(e => e.ManFathersName)
                    .HasColumnName("manFathersName")
                    .HasMaxLength(255);

                entity.Property(e => e.Signature1).HasColumnName("signature1");

                entity.Property(e => e.Signature2).HasColumnName("signature2");

                entity.Property(e => e.Signature3).HasColumnName("signature3");

                entity.Property(e => e.TreatmentDescription)
                    .HasColumnName("treatmentDescription")
                    .HasMaxLength(255);
                entity.Property(e => e.TreatmentsTime)
                   .HasColumnName("treatmentsTime")
                   .HasMaxLength(255);
                

                entity.Property(e => e.WomanFathersName)
                    .HasColumnName("womanFathersName")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorTreatment)
                    .HasColumnName("doctorTreatment")
                    .HasMaxLength(255);

                entity.HasOne(d => d.ClinicVisits)
                    .WithMany(p => p.Insemination)
                    .HasForeignKey(d => d.ClinicVisitsId)
                    .HasConstraintName("FK_InseminationClinicVisits");
            });

            modelBuilder.Entity<Iui>(entity =>
            {
                entity.ToTable("IUI");

                entity.Property(e => e.Iuiid).HasColumnName("IUIID");

                entity.Property(e => e.Appearance)
                    .HasColumnName("appearance")
                    .HasMaxLength(255);

                entity.Property(e => e.ClinicVisitsId).HasColumnName("clinicVisitsId");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(255);

                entity.Property(e => e.GivingTimeString)
                    .HasColumnName("givingTimeString")
                    .HasMaxLength(255);

                entity.Property(e => e.CommentsTreatment)
                    .HasColumnName("commentsTreatment")
                    .HasMaxLength(255);

                entity.Property(e => e.Conc105cc)
                    .HasColumnName("conc105cc")
                    .HasMaxLength(255);

                entity.Property(e => e.Conc105ccAfterTreatment)
                    .HasColumnName("conc105ccAfterTreatment")
                    .HasMaxLength(255);

                entity.Property(e => e.Condom).HasColumnName("condom");

                entity.Property(e => e.Cup).HasColumnName("cup");

                entity.Property(e => e.Ejac).HasColumnName("ejac");

                entity.Property(e => e.EmailForSendingResults).HasMaxLength(255);

                entity.Property(e => e.Fresh).HasColumnName("fresh");

                entity.Property(e => e.GivingTime)
                    .HasColumnName("givingTime")
                    .HasColumnType("dateTime");

                entity.Property(e => e.DoctorTreatment)
                    .HasColumnName("doctorTreatment")
                    .HasMaxLength(255);

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasMaxLength(255);
                entity.Property(e => e.PH)
                  .HasColumnName("PH")
                  .HasMaxLength(255);

                entity.Property(e => e.GradeAfterTreatment)
                    .HasColumnName("gradeAfterTreatment")
                    .HasMaxLength(255);

                entity.Property(e => e.Motility)
                    .HasColumnName("motility")
                    .HasMaxLength(255);

                entity.Property(e => e.Motility_rank_1)
                 .HasColumnName("motility_rank_1")
                 .HasMaxLength(255);

                entity.Property(e => e.Motility_rank_2)
                    .HasColumnName("motility_rank_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Motility_rank_3)
                    .HasColumnName("motility_rank_3")
                    .HasMaxLength(255);

                entity.Property(e => e.Motility_rank_4)
                    .HasColumnName("motility_rank_4")
                    .HasMaxLength(255);
                

                entity.Property(e => e.MotilityAfterTreatment)
                    .HasColumnName("motilityAfterTreatment")
                    .HasMaxLength(255);

                entity.Property(e => e.MotilityAfterTreatment_1)
                 .HasColumnName("motilityAfterTreatment_1")
                 .HasMaxLength(255);

                entity.Property(e => e.MotilityAfterTreatment_2)
                   .HasColumnName("motilityAfterTreatment_2")
                   .HasMaxLength(255);

                entity.Property(e => e.MotilityAfterTreatment_3)
                   .HasColumnName("motilityAfterTreatment_3")
                   .HasMaxLength(255);
                entity.Property(e => e.MotilityAfterTreatment_4)
                   .HasColumnName("motilityAfterTreatment_4")
                   .HasMaxLength(255);

                entity.Property(e => e.PHAfterTreatment)
                   .HasColumnName("PHAfterTreatment")
                   .HasMaxLength(255);
                

                entity.Property(e => e.Other)
                    .HasColumnName("other")
                    .HasMaxLength(255);

                entity.Property(e => e.OtherTreatment).HasColumnName("otherTreatment");

                entity.Property(e => e.TotalMotileCount).HasMaxLength(255);

                entity.Property(e => e.VolumeCc)
                    .HasColumnName("volumeCc")
                    .HasMaxLength(255);

                entity.Property(e => e.VolumeCcAfterTreatment)
                    .HasColumnName("volumeCcAfterTreatment")
                    .HasMaxLength(255); 
                entity.Property(e => e.FolliclesNumber)
              .HasColumnName("folliclesNumber")
              .HasMaxLength(255);

        entity.Property(e => e.WimUp).HasColumnName("wimUp");

                entity.HasOne(d => d.ClinicVisits)
                    .WithMany(p => p.Iui)
                    .HasForeignKey(d => d.ClinicVisitsId)
                    .HasConstraintName("FK_IUIClinicVisits");
            });

            modelBuilder.Entity<Pct>(entity =>
            {
                entity.ToTable("PCT");

                entity.Property(e => e.Pctid).HasColumnName("PCTID");

                entity.Property(e => e.Amount).HasMaxLength(255);

                entity.Property(e => e.Cellularity).HasMaxLength(255);

                entity.Property(e => e.Clarity).HasMaxLength(255);

                entity.Property(e => e.ClinicVisitsId).HasColumnName("clinicVisitsId");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(255);

                entity.Property(e => e.Elasticity)
                    .HasColumnName("elasticity")
                    .HasMaxLength(255);

                entity.Property(e => e.Fernig).HasMaxLength(255);

                entity.Property(e => e.GoodMotileSperm)
                    .HasColumnName("goodMotileSperm")
                    .HasMaxLength(255);

                entity.Property(e => e.HoursPost)
                    .HasColumnName("hoursPost")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorTreatment)
                    .HasColumnName("doctorTreatment")
                    .HasMaxLength(255);

                entity.Property(e => e.MensesDay).HasMaxLength(255);

                entity.Property(e => e.TotalSpermsHpf)
                    .HasColumnName("totalSpermsHPF")
                    .HasMaxLength(255);

                entity.HasOne(d => d.ClinicVisits)
                    .WithMany(p => p.Pct)
                    .HasForeignKey(d => d.ClinicVisitsId)
                    .HasConstraintName("FK_PCTClinicVisits");
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.Property(e => e.PersonsId).HasColumnName("personsID");

                entity.Property(e => e.Addres)
                    .HasColumnName("addres")
                    .HasMaxLength(255);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.DateMarriage)
                    .HasColumnName("dateMarriage")
                    .HasColumnType("date");

                entity.Property(e => e.FamilyName)
                    .HasColumnName("familyName")
                    .HasMaxLength(255);

                entity.Property(e => e.ManDateBirth)
                    .HasColumnName("manDateBirth")
                    .HasColumnType("date");

                entity.Property(e => e.ManEmail)
                    .HasColumnName("manEmail")
                    .HasMaxLength(255);

                entity.Property(e => e.ManFathersName)
                    .HasColumnName("manFathersName")
                    .HasMaxLength(255);

                entity.Property(e => e.ManId).HasColumnName("manId");

                entity.Property(e => e.ManName)
                    .HasColumnName("manName")
                    .HasMaxLength(255);

                entity.Property(e => e.ManPhone)
                    .HasColumnName("manPhone")
                    .HasMaxLength(255);

                entity.Property(e => e.NumberChildren).HasColumnName("numberChildren");
               

                entity.Property(e => e.Register).HasColumnName("register");

                entity.Property(e => e.BrothersToTfila).HasColumnName("brothersToTfila");
                

                entity.Property(e => e.WomanDateBirth)
                    .HasColumnName("womanDateBirth")
                    .HasColumnType("date");

                entity.Property(e => e.WomanEmail)
                    .HasColumnName("womanEmail")
                    .HasMaxLength(255);

                entity.Property(e => e.WomanFathersName)
                    .HasColumnName("womanFathersName")
                    .HasMaxLength(255);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(255); 

                entity.Property(e => e.WomanId).HasColumnName("womanId");

                entity.Property(e => e.WomanName)
                    .HasColumnName("womanName")
                    .HasMaxLength(255);

                entity.Property(e => e.WomanPhone)
                    .HasColumnName("womanPhone")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Sa>(entity =>
            {
                entity.ToTable("SA");

                entity.Property(e => e.Said).HasColumnName("SAID");

                entity.Property(e => e.AmorphousHeads)
                    .HasColumnName("amorphousHeads")
                    .HasMaxLength(255);
                entity.Property(e => e.GivingTimeString)
                  .HasColumnName("givingTimeString")
                  .HasMaxLength(255);

                entity.Property(e => e.Appearance)
                    .HasColumnName("appearance")
                    .HasMaxLength(255);

                entity.Property(e => e.ClinicVisitsId).HasColumnName("clinicVisitsId");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(255);

                entity.Property(e => e.Conc105cc)
                    .HasColumnName("conc105cc")
                    .HasMaxLength(255);

                entity.Property(e => e.Condom).HasColumnName("condom");

                entity.Property(e => e.Cup).HasColumnName("cup");

                entity.Property(e => e.CytoplasmicDroplets)
                    .HasColumnName("cytoplasmicDroplets")
                    .HasMaxLength(255);

                entity.Property(e => e.DoctorTreatment)
                    .HasColumnName("doctorTreatment")
                    .HasMaxLength(255);

                entity.Property(e => e.Ejac).HasColumnName("ejac");

                entity.Property(e => e.Fresh).HasColumnName("fresh");

                entity.Property(e => e.GivingTime)
                    .HasColumnName("givingTime")
                    .HasColumnType("dateTime");

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasMaxLength(255);

                entity.Property(e => e.LargeHeads)
                    .HasColumnName("largeHeads")
                    .HasMaxLength(255);

                entity.Property(e => e.Motility)
                    .HasColumnName("motility")
                    .HasMaxLength(255);

                entity.Property(e => e.Motility_rank_1)
                    .HasColumnName("motility_rank_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Motility_rank_2)
                    .HasColumnName("motility_rank_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Motility_rank_3)
                    .HasColumnName("motility_rank_3")
                    .HasMaxLength(255);

                entity.Property(e => e.Motility_rank_4)
                    .HasColumnName("motility_rank_4")
                    .HasMaxLength(255);

                entity.Property(e => e.NeckDefects)
                    .HasColumnName("neckDefects")
                    .HasMaxLength(255);

                entity.Property(e => e.NormalForms)
                    .HasColumnName("normalForms")
                    .HasMaxLength(255);

                entity.Property(e => e.Other)
                    .HasColumnName("other")
                    .HasMaxLength(255);

                entity.Property(e => e.Ph)
                    .HasColumnName("PH")
                    .HasMaxLength(255);

                entity.Property(e => e.PinHeads)
                    .HasColumnName("pinHeads")
                    .HasMaxLength(255);

                entity.Property(e => e.PyramidalHeads)
                    .HasColumnName("pyramidalHeads")
                    .HasMaxLength(255);

                entity.Property(e => e.RoundHeads)
                    .HasColumnName("roundHeads")
                    .HasMaxLength(255);

                entity.Property(e => e.SmallHeads)
                    .HasColumnName("smallHeads")
                    .HasMaxLength(255);

                entity.Property(e => e.TailDefects)
                    .HasColumnName("tailDefects")
                    .HasMaxLength(255);

                entity.Property(e => e.GivingSample)
                  .HasColumnName("givingSample")
                  .HasMaxLength(255);

                entity.Property(e => e.DaysAvoided)
                  .HasColumnName("daysAvoided")
                  .HasMaxLength(255);

                entity.Property(e => e.Signature)
                  .HasColumnName("signature")
                  .HasColumnType("VARCHAR(MAX)");

                entity.Property(e => e.TaperedHeads)
                    .HasColumnName("taperedHeads")
                    .HasMaxLength(255);

                entity.Property(e => e.VolumeCc)
                    .HasColumnName("volumeCc")
                    .HasMaxLength(255);

                entity.HasOne(d => d.ClinicVisits)
                    .WithMany(p => p.Sa)
                    .HasForeignKey(d => d.ClinicVisitsId)
                    .HasConstraintName("FK_SAClinicVisits");
            });

            modelBuilder.Entity<Subsidization>(entity =>
            {
                entity.Property(e => e.SubsidizationId).HasColumnName("SubsidizationID");

                entity.Property(e => e.CheckNumber).HasColumnName("checkNumber");

                entity.Property(e => e.CheckedBy)
                    .HasColumnName("checkedBy")
                    .HasMaxLength(255);

                entity.Property(e => e.ClinicVisitsId).HasColumnName("clinicVisitsId");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(255);

                entity.Property(e => e.CommentsOffice)
                    .HasColumnName("commentsOffice")
                    .HasMaxLength(255);

                entity.Property(e => e.DatePlease)
                    .HasColumnName("datePlease")
                    .HasColumnType("date");

                entity.Property(e => e.ManWork)
                    .HasColumnName("manWork")
                    .HasMaxLength(255);

                entity.Property(e => e.RabbiName).HasMaxLength(255);

                entity.Property(e => e.RabbiPhone).HasMaxLength(255);

                entity.Property(e => e.RequestReceived).HasColumnName("requestReceived");

                entity.Property(e => e.WomanWork)
                    .HasColumnName("womanWork")
                    .HasMaxLength(255);

                entity.HasOne(d => d.ClinicVisits)
                    .WithMany(p => p.SubsidizationNavigation)
                    .HasForeignKey(d => d.ClinicVisitsId)
                    .HasConstraintName("FK_SubsidizationClinicVisits");
            });

            modelBuilder.Entity<Treatments>(entity =>
            {
                entity.HasKey(e => e.TreatmentId);

                entity.Property(e => e.TreatmentId).HasColumnName("treatmentID");

                entity.Property(e => e.TreatmentCost).HasColumnName("treatmentCost");

                entity.Property(e => e.TreatmentName)
                    .HasColumnName("treatmentName")
                    .HasMaxLength(255);
            });
            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(255);
                entity.Property(e => e.UserPassword)
                  .HasColumnName("userPassword")
                  .HasMaxLength(255);

                entity.Property(e => e.UserPermission).HasColumnName("userPermission");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
