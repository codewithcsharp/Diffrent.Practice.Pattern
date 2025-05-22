using Microsoft.AspNetCore.Mvc; 
 using ContactApi.Models; 
 using ContactApi.Data; 
 
 [ApiController] 
 [Route("api/[controller]")] 
 public class ContactController : ControllerBase 
 { 
 private readonly ApplicationDbContext _context; 
 
 public ContactController(ApplicationDbContext context) 
 { 
 _context = context; 
 } 
 
 [HttpPost] 
 public IActionResult PostContact([FromBody] Contact contact) 
 { 
 if (!ModelState.IsValid) 
 { 
 return BadRequest(ModelState); 
 } 
 
 _context.Contacts.Add(contact); 
 _context.SaveChanges(); 
 
 return Ok(); 
 } 
 } 
