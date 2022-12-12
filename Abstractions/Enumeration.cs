using System.Reflection;

namespace DDD.Foundations;

public abstract record class Enumeration
{
    public int Id { get; init; }
    public string? Name { get; init; }

    public static IEnumerable<T> GetAll<T>() where T : Enumeration
    {
        // TODO implement for hierarchy of Enumerations 
        var flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly;
        var fields = typeof(T).GetFields(flags);
        var all = fields.Select(f => f.GetValue(null));
        return all.Cast<T>();
    }

    public static T? GetById<T>(int id) where T : Enumeration =>
        GetAll<T>().FirstOrDefault(item => item.Id == id);

    public static T? GetByName<T>(string name) where T : Enumeration =>
        GetAll<T>().FirstOrDefault(item => item.Name == name);

    //protected static Enumeration? Create(Type type, params object[] args) =>
    //    (Enumeration?)Activator.CreateInstance(type, args);
}





//public abstract record class Enumeration(int Id, string Name)
//{
//    protected Enumeration() : this(0, "") { }

//    public static IEnumerable<T> GetAll<T>() where T : Enumeration, new()
//    {
//        var flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly;
//        var fields = typeof(T).GetFields(flags);
//        var all = fields.Select(f => f.GetValue(null));
//        return all.Cast<T>();
//    }
//}

//        var flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy;

//return fields.Select(f => f.GetValue(null)).Cast<T>();

//var instance = new T();

//var z = instance.GetType().BaseType;
//System.Reflection.ConstructorInfo[] constructors = z.GetConstructors(flags);
////constructors[0].Invoke();
////var zInstance =
////var fields1 = typeof(z).GetFields(flags);


//foreach (var info in fields)
//{
//    //   var instance = new z();
//    var locatedValue = info.GetValue(instance);

//    if (locatedValue != null)
//    {
//        yield return (T)locatedValue;
//    }
//}




//public abstract record class Enumeration(int Id, string Name)
//{
//    protected Enumeration() : this(0, "") { }

//    //public static int Difference(Enumeration firstValue, Enumeration secondValue) =>
//    //    Math.Abs(firstValue.Id - secondValue.Id);

//    //    public static IEnumerable<Type?> GetAll<T>() where T : Enumeration, new()
//    public static IEnumerable<T> GetAll<T>() where T : Enumeration, new()
//    {
//        var flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy;//.DeclaredOnly;
//        var fields = typeof(T).GetFields(flags);
//        //var all = fields.Select(f => f.GetValue(null)).Cast<T>();
//        //return all;

//        //return fields.Select(f => f.GetValue(null)).Cast<T>();

//        var instance = new T();

//        var z = instance.GetType().BaseType;
//        System.Reflection.ConstructorInfo[] constructors = z.GetConstructors(flags);
//        //constructors[0].Invoke();
//        //var zInstance =
//        //var fields1 = typeof(z).GetFields(flags);


//        foreach (var info in fields)
//        {
//            //   var instance = new z();
//            var locatedValue = info.GetValue(instance);

//            if (locatedValue != null)
//            {
//                yield return (T)locatedValue;
//            }
//        }
//    }

//    public static T? GetById<T>(int id) where T : Enumeration, new() =>
//        GetAll<T>().FirstOrDefault(item => item.Id == id);

//    public static T? GetByName<T>(string name) where T : Enumeration, new() =>
//        GetAll<T>().FirstOrDefault(item => item.Name == name);

//    //public static T GetById<T>(int id) where T : Enumeration, new() =>
//    //    Find<T, int>(id, "Id", item => item.Id == id);

//    //public static T GetByName<T>(string name) where T : Enumeration, new() =>
//    //    Find<T, string>(name, "Name", item => item.Name == name);

//    //private static T Find<T, V>(V value, string msg, Func<T, bool> predicate) where T : Enumeration, new()
//    //{
//    //    var item = GetAll<T>().FirstOrDefault(predicate);
//    //    if (item != null)
//    //        return item;
//    //    throw new ApplicationException($"'{value}' is not a valid {msg} in {typeof(T)}.");
//    //}

//    //}

//}
