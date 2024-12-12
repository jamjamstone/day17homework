namespace day17homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trainer trainer = new Trainer();
            Charmander charmander = new Charmander("파이리",5);
            trainer.AddMonster(charmander);
            trainer.AllAttack();
        }
    }
}
