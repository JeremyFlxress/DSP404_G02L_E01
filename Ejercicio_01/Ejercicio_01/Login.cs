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
        private string categoria;
        Dictionary<string, string> GameOfThrones = new Dictionary<string, string>();
        Dictionary<string, string> Libros = new Dictionary<string, string>();
        Dictionary<string, string> LenguajesProgramacion = new Dictionary<string, string>();

        public Login(string selecionCategoria)
        {
            InitializeComponent();
            categoria = selecionCategoria;

            ActualizarContenido();
        }

        private void ActualizarContenido()
        {
            GameOfThrones.Add("Protagonistas: ", "Sean Bean\r\nNikolaj Coster-Waldau\r\nPeter Dinklage\r\nEmilia Clarke\r\nLena Headey\r\nIain Glen\r\nKit " +
                                "Harington\r\nSophie Turner\r\nMaisie Williams\r\nIsaac Hempstead-Wright\r\nNatalie Dormer");
            GameOfThrones.Add("Título en español:: ", "Juego de tronos");
            GameOfThrones.Add("Creado por: ", "• David Benioff\n• D. B. Weiss");
            GameOfThrones.Add("País de origen: ", "Estados Unidos");
            GameOfThrones.Add("Temporadas: ", "8");
            GameOfThrones.Add("Episodios: ", "73");
            GameOfThrones.Add("Sinopsis: ", "La trama de Game of\r\nThrones está basada en la\r\nserie de novelas Canción de" +
                              "\r\nhielo y fuego, y relata las\r\nvivencias de un grupo de\r\npersonajes de distintas casas\r" +
                              "\nnobiliarias en el continente\r\nficticio Poniente para tener el\r\ncontrol del Trono de Hierro y\r\ngobernar los siete reinos que\r\nconforman el territorio");

            switch (categoria)
            {
                case "Entretenimiento":
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

                    break;
                case "Libros":
                    lblTitulo1.Text = "Harry Potter";
                    txtIProtagonistas.Text = "Pruebas Libros";
                    break;
                case "Lenguajes de Programacion":
                    lblTitulo1.Text = "JavaScript";
                    txtIProtagonistas.Text = "Pruebas Piton";
                    break;
                default:
                    break;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Añadiendo palabras a Entretimiento



            Libros.Add("Protagonistas: ", "Harry Potter\r\nRon weasley\r\nHermione Granger\r\nGinny Weasley\r\nNeville Longbottom\r\nAlbus Dumbledore");

            LenguajesProgramacion.Add("Paradigma: ", "Multiparadigma: orientado a\r\nobjetos, imperativo, funcional,\r\nreflexivo");
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
    }
}
