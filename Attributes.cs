namespace FichaOrdemParanormal
{
    public class Attributes
    {
        public Attributes(int ID, string name, int value)
        {
            this.ID = ID;
            Name = name;
            Valor = value;
        }
        public int ID { get; set; }
        public int Valor { get; set; }
        public string Name { get; set; }

    }
}
