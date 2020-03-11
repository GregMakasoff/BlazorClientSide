using System;
using Microsoft.EntityFrameworkCore;
using SchoolLibrary;

namespace SchoolApi.Data
{
public class SchoolDbContext : DbContext {
  public DbSet<Speaker> Speakers { get; set; }

  public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

  protected override void OnModelCreating(ModelBuilder builder) {
    base.OnModelCreating(builder);

    builder.Entity<Speaker>().HasData(
      new {
        SpeakerId = Guid.NewGuid().ToString(),
        FirstName = "Tom",
        LastName = "Day",
        Email = "tomDay@gmail.com",
        MobileNumber = "778-859-3447",
        AreaOfSpec = "Mechanics",
        City = "Burnaby",
        Province = "BC",
        Employer = "BC Hydro"
      }, new {
        SpeakerId = Guid.NewGuid().ToString(),
        FirstName = "Fred",
        LastName = "Night",
        Email = "fNight@gmail.com",
        MobileNumber = "778-333-1465",
        AreaOfSpec = "Biomechanics",
        City = "Burnaby",
        Province = "BC",
        Employer = "Lex Luthor"
      }, new {
        SpeakerId = Guid.NewGuid().ToString(),
        FirstName = "Phil",
        LastName = "McKracken",
        Email = "phillipKrak@gmail.com",
        MobileNumber = "778-010-3111",
        AreaOfSpec = "Flatulence",
        City = "Burnaby",
        Province = "BC",
        Employer = "Beans R' Us"
      }, new {
        SpeakerId = Guid.NewGuid().ToString(),
        FirstName = "Ben",
        LastName = "Dover",
        Email = "getOuttaThere@gmail.com",
        MobileNumber = "778-859-6969",
        AreaOfSpec = "Prostate Exams",
        City = "Burnaby",
        Province = "BC",
        Employer = "Uncle Bob"
      }
    );
  }
}

}