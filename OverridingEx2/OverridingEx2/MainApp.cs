namespace OverridingEx2
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Ryu ryu = new Ryu();
            Ken ken = new Ken();
            Guile guile = new Guile();

            ryu.forward();
            ryu.energy();
            ryu.kick();

            ken.backward();
            ken.energy();
            ken.kick();

            guile.jump();
            guile.energy();
            guile.kick();
        }
    }
}
