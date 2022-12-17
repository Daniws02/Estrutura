using System.Collections.Generic;

class User
{   
    public int Id;
    public string Nome;
    public int Tipo;
    public User(int id, string nome, int tipo)
    {
        this.Id = id;
        this.Nome = nome;
        this.Tipo = tipo;
    }
    public static List<User> Increase(List<User>Lista)
    {   
        return Lista;
    }
}