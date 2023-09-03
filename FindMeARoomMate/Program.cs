
//Presentation Layer
using FindMeARoomMate.DataLayer.DBContext;
using FindMeARoomMate.DataLayer.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello");

            FindMeRoomMateDBContext findMeRoomMateDBCotext  = new FindMeRoomMateDBContext();
            findMeRoomMateDBCotext.Add(new Students() { FullName = "Aksel Shehaj" });
            await findMeRoomMateDBCotext.SaveChangesAsync();

            var student = await findMeRoomMateDBCotext.Students.ToListAsync();
            student.ForEach(student => { Console.WriteLine(student.FullName); });


var deleteStudent = await findMeRoomMateDBCotext.Students.Where(s => s.Id == 10).FirstOrDefaultAsync();
if (deleteStudent == null)
{
    throw new Exception("Studnet not found");
}
findMeRoomMateDBCotext.Students.Remove(deleteStudent);
await findMeRoomMateDBCotext.SaveChangesAsync();

