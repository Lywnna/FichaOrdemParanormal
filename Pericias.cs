namespace FichaOrdemParanormal
{
    public class Pericias
    {
        public Pericias(int ID, int ID_Atributos, string Atributos, int bonus, string nome)
        {
            this.ID = ID;
            this.Atributos = Atributos;
            this.ID_Atributos = ID_Atributos;
            Bonus = bonus;
            Nome = nome;
        }

        public int ID { get; set; }
        public int ID_Atributos { get; set; }
        public string Atributos { get; set; }
        public int Bonus { get; set; }
        public string Nome { get; set; }
    }
}
