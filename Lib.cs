using System;

namespace Lib {
  public abstract class BaseEntity {
    public String MyData() {
      return "some stuff...";
    }
  }
  public abstract class BaseAddress : BaseEntity {}
  public class Address: BaseAddress {} 

  // repos
  public abstract class BaseRepository<TEntity> where TEntity:BaseEntity {
    public void save(TEntity entity) {
      Console.WriteLine($"saving: [{entity.MyData()}].");
    }
  }
  public class AddressRepository : BaseRepository<Address> {}
}