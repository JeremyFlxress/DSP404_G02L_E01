using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class Login : Form
    {
        public string categoriaSeleccionada;
        private string eleccion;
        Dictionary<string, string> GameOfThrones = new Dictionary<string, string>();
        Dictionary<string, string> Chernobyl = new Dictionary<string, string>();
        Dictionary<string, string> Maisel = new Dictionary<string, string>();

        public Login(string CategoriaSeleccionada)
        {
            InitializeComponent();
            categoriaSeleccionada = CategoriaSeleccionada;


        }

    private void ActualizarContenido()
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Agregar informacion de GameOhThrones
            GameOfThrones.Add("Protagonistas: ", "Sean Bean Nikolaj Coster-Waldau Peter Dinklage Emilia Clarke Lena Headey Iain Glen Kit " +
                              "Harington Sophie Turner Maisie Williams Isaac Hempstead-Wright Natalie Dormer");
            GameOfThrones.Add("Título en español: ", "Juego de tronos");
            GameOfThrones.Add("Creado por: ", "• David Benioff\n• D. B. Weiss");
            GameOfThrones.Add("País de origen: ", "Estados Unidos");
            GameOfThrones.Add("Temporadas: ", "8");
            GameOfThrones.Add("Episodios: ", "73");
            GameOfThrones.Add("Sinopsis: ", "La trama de Game of Thrones está basada en la\r\nserie de novelas Canción de" +
                              " hielo y fuego, y relata las\r\nvivencias de un grupo de personajes de distintas casas\r" +
                              "\nnobiliarias en el continente ficticio Poniente para tener el\r\ncontrol del Trono de Hierro y gobernar los siete reinos que\r\nconforman el territorio");

            //Agregar informacion de Chernobyl
            Chernobyl.Add("Protagonistas: ", "Jared Harris\r\nStellan Skarsgård\r\nEmily Watson");
            Chernobyl.Add("Título en español: ", "Chernóbil");
            Chernobyl.Add("Creado por: ", "Craig Mazin");
            Chernobyl.Add("País de origen: ", "Estados Unidos");
            Chernobyl.Add("Temporadas: ", "1");
            Chernobyl.Add("Episodios: ", "5");
            Chernobyl.Add("Sinopsis: ", "La serie gira en torno al desastre nuclear de Chernóbil de abril de 1986 y los esfuerzos de limpieza sin precedentes que siguieron. Cuenta con un reparto encabezado por Jared Harris, Stellan Skarsgård y Emily Watson.");


            //Agregar informacion de The Marvelous Mrs.Maisel
            Maisel.Add("Protagonistas: ", "Rachel Brosnahan\r\nMichael Zegen\r\nAlex Borstein\r\nTony Shalhoub\r\nMarin Hinkle");
            Maisel.Add("Título en español: ", "La maravillosa Señora Maisel");
            Maisel.Add("Creado por: ", "Amy Sherman-Palladino");
            Maisel.Add("País de origen: ", "Estados Unidos");
            Maisel.Add("Temporadas: ", "3");
            Maisel.Add("Episodios: ", "26");
            Maisel.Add("Sinopsis: ", "La serie cuenta la historia de un ama de casa en Nueva York que descubre que tiene una habilidad especial para la comedia en vivo. El primer episodio se estrenó como parte de la temporada de pilotos de primavera de Amazon Studios el 17 de marzo de 2017, recibiendo ");
        }

        private void lblProtagonistas_Click(object sender, EventArgs e)
        {

        }

        private void txtIProtagonistas_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSinopsis_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSinopsis.Clear();
            txtIProtagonistas.Clear();
            txtPaisOrigen.Clear();
            txtCreadoPor.Clear();
            txtTemporadas.Clear();
            txtEpisodios.Clear();


            var Protagonistas = GameOfThrones.ElementAt(0);
            var TituloEspañol = GameOfThrones.ElementAt(1);
            var CreadoPor = GameOfThrones.ElementAt(2);
            var PaisOrigen = GameOfThrones.ElementAt(3);
            var Temporadas = GameOfThrones.ElementAt(4);
            var Episodios = GameOfThrones.ElementAt(5);
            var Sinopsis = GameOfThrones.ElementAt(6);

            lblTitulo1.Text = "Game Of Thrones";
            lblTituloEspañol.Text = TituloEspañol.Value;
            txtSinopsis.Text = Sinopsis.Value;
            txtIProtagonistas.Text = Protagonistas.Value;
            txtPaisOrigen.Text = PaisOrigen.Value;
            txtCreadoPor.Text = CreadoPor.Value;
            txtTemporadas.Text = Temporadas.Value;
            txtEpisodios.Text = Episodios.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSinopsis.Clear();
            txtIProtagonistas.Clear();
            txtPaisOrigen.Clear();
            txtCreadoPor.Clear();
            txtTemporadas.Clear();
            txtEpisodios.Clear();


            var Protagonistas = Chernobyl.ElementAt(0);
            var TituloEspañol = Chernobyl.ElementAt(1);
            var CreadoPor = Chernobyl.ElementAt(2);
            var PaisOrigen = Chernobyl.ElementAt(3);
            var Temporadas = Chernobyl.ElementAt(4);
            var Episodios = Chernobyl.ElementAt(5);
            var Sinopsis = Chernobyl.ElementAt(6);

            lblTitulo1.Text = "Chernobyl";
            lblTituloEspañol.Text = TituloEspañol.Value;
            txtSinopsis.Text = Sinopsis.Value;
            txtIProtagonistas.Text = Protagonistas.Value;
            txtPaisOrigen.Text = PaisOrigen.Value;
            txtCreadoPor.Text = CreadoPor.Value;
            txtTemporadas.Text = Temporadas.Value;
            txtEpisodios.Text = Episodios.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSinopsis.Clear();
            txtIProtagonistas.Clear();
            txtPaisOrigen.Clear();
            txtCreadoPor.Clear();
            txtTemporadas.Clear();
            txtEpisodios.Clear();


            var Protagonistas = Maisel.ElementAt(0);
            var TituloEspañol = Maisel.ElementAt(1);
            var CreadoPor = Maisel.ElementAt(2);
            var PaisOrigen = Maisel.ElementAt(3);
            var Temporadas = Maisel.ElementAt(4);
            var Episodios = Maisel.ElementAt(5);
            var Sinopsis = Maisel.ElementAt(6);

            lblTitulo1.Text = "The Marvelous Mrs.Maisel";
            lblTituloEspañol.Text = TituloEspañol.Value;
            txtSinopsis.Text = Sinopsis.Value;
            txtIProtagonistas.Text = Protagonistas.Value;
            txtPaisOrigen.Text = PaisOrigen.Value;
            txtCreadoPor.Text = CreadoPor.Value;
            txtTemporadas.Text = Temporadas.Value;
            txtEpisodios.Text = Episodios.Value;
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            Estadística Estadistica = new Estadística(categoriaSeleccionada);
            Estadistica.Show();

            this.Hide();
        }
    }
}
