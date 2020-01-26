// namespace creates scopes of code together across files
namespace one
{

}


// class can be extended and have default values
public class Test
{

}

//  struct can not have default values and can not be extended. usefull for data
public struct Test2
{

}

// interface is used to create a software api that builds a generic layer where you can apply the same name to mulitple classes and structs 

public interface IExample
{
  // function declaration without body
  void Example();

}

// example using interface


public class UsingInterface : IExample
{
  // interfaces function declarations are implied public
  public void Example()
  {
    // this is where the function body goes specific to this class 
  }
}

/* Example of intillisence coding */

/// <summary>
/// Does a thing
///</summary>
public class ICanTellYouWhatsUp
{
  /// <summary>
  /// returns the mulitpulcation of param one and param two
  ///</summary>
  ///<param name='int1'>First int</param>
  ///<param name='int2'>Second int</param>
  public float Update(float int1, float int2)
  {
    return int1 * int2;
  }
}

namespace lonely
{
  // properties example
  public class Player
  {
    // if you do not say public it will be private to only this class
    float health = 100f;

    public float Health
    {
      get
      {
        return health;
      }
      set
      {
        if (value < 0)
          health = 0;
        else if (value > 100)
          health = 100;
        else
          health = value;
      }
    }

  }
}