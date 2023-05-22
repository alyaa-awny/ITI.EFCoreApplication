namespace EFCore.Model;

//[Table("Dept")] //data anotation
public class Employee
{
    //[Key] //data anotation
    public int ID { get; set; }
    // [Required]//data anotation
    public string Name { get; set; }
    //[ForeignKey("Department")]
    public int Id { get; set; }
    public virtual Department Department { get; set; }

}
//how to write model classes inwith EF runtime?
//1. convension
//2.Data anotation
//3. fluent api
//4.external configration class
