using EFCore.Entities;
using EFCore.Model;

#region EFV01
//CompanyContext db = new CompanyContext();
////db.Database.EnsureDeleted();
////db.Database.EnsureCreated();

//Employee e1 = new Employee() { Name = "Alyaa" };
////Add employee to local storage
//db.Employees.Add(e1);
////save new employee in database---Reflect on database
//db.SaveChanges(); 
#endregion

#region EFV02
CompanyContext db = new CompanyContext();
db.Database.EnsureDeleted();
db.Database.EnsureCreated();
Department d1 = new Department { Name = "SD" };
Employee e1 = new Employee { Name = "amira" };
db.Departments.Add(d1);
db.Employees.Add(e1);
db.SaveChanges();

#endregion

#region Employee
//CompanyContext db = new CompanyContext();
//db.Database.EnsureDeleted();
//db.Database.EnsureCreated();

//var d1 = db.Departments.First();
//Employee e1 = new Employee { Name = "Ahmed", Department = d1 };
//db.Add(e1);
//db.SaveChanges();
#endregion