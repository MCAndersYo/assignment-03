namespace Assignment3.Entities;

public class User
{
   public int Id { get; set; }

   public string Name { get; set; }

   public string Email { get; set; }

   public List<WorkItem> WorkItems { get; set; }

   public User(string name, string email) {
      Name = name;

      Email = email;
   }


}
