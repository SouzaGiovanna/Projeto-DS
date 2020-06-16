namespace prjCadVisu.Model
{
    public class Client : Person
    {
        public Client(string name, string cpf, string rg, string address)
        {
            Name = name;
            CPF = cpf;
            RG = rg;
            Address = address;
        }
    }
}
