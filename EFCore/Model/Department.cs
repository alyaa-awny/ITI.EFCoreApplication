namespace EFCore.Model
{
    public class Department
    {
        //[Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
