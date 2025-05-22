using Microsoft.EntityFrameworkCore; 
 using ContactApi.Models; 
 
 public class ApplicationDbContext : DbContext 
 { 
 public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
 { 
 } 
 
 public DbSet<Contact> Contacts { get; set; } 
 } 
