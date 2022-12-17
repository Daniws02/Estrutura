using System.Collections.Generic;

class Key
{
    public static void Restrition(List<User> Users, List<Type> Types)
    {
        foreach(var i in Types)
        {
            foreach(var j in Users)
            {
                if(i.Tipo != j.Tipo)
                {
                    Users.Remove(j);
                }
            }
        }
    }
}