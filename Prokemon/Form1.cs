using Prokemon.pokemons;

namespace Prokemon
{
    public partial class Form1 : Form
    {
        List<Prokemon1> pokemons;
        Prokemon1 selectedPokemon;
        Prokemon1 monster;
        public Form1()
        {
            InitializeComponent();

            pokemons = new List<Prokemon1>();
            pokemons.Add(new Squirtle());
            pokemons.Add(new Charmander());
            pokemons.Add(new Blastoise());
            pokemons.Add(new Pikachu());

            this.monster = new Bellsprout();
            this.pictureBox2.Image = this.monster.getImage();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBoxName.Text = selectedPokemon.getName();
            this.textBox2.Text = selectedPokemon.getHP().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.textBoxName.Text = selectedPokemon.getName();
            this.pictureBox1.Image = selectedPokemon.getImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.textBoxName.Text = selectedPokemon.getName();
            this.pictureBox1.Image = selectedPokemon.getImage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.textBoxName.Text = selectedPokemon.getName();
            this.pictureBox1.Image = selectedPokemon.getImage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int damage = this.monster.getDefense()
                - this.selectedPokemon.getAttack();
            this.monster.takeDamage(damage);
            //display data
            this.textBox1.Text = selectedPokemon.getHP().ToString();
        }
    }
}