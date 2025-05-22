var builder = WebApplication.CreateBuilder(args); 
 
 var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); 
 builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString)); 
 
 builder.Services.AddEndpointsApiExplorer(); 
 builder.Services.AddSwaggerGen(); 
 
 var app = builder.Build(); 
 
 app.UseHttpsRedirection(); 
 app.UseAuthorization(); 
 
 app.MapPost("/api/contact", ([FromBody] Contact contact, ApplicationDbContext context) => 
 { 
 if (!ModelState.IsValid) 
 { 
 return BadRequest(ModelState); 
 } 
 
 context.Contacts.Add(contact); 
 context.SaveChanges(); 
 
 return Ok(); 
 }); 
 
 app.UseSwagger(); 
 app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Contact API")); 
 
 app.Run(); 
