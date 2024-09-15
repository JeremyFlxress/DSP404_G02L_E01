using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Notas_Complementario.Models;
using System.Data.SqlClient;

namespace Notas_Complementario.Controllers
{
    public class NotasController : Controller
    {
        private Conexion conexion = new Conexion();

        public ActionResult Index()
        {
            var listaNotas = new List<Nota>();
            var comando = new SqlCommand("SELECT * FROM notas", conexion.GetConexion());

            conexion.AbrirConexion();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                var nota = new Nota
                {
                    Codigo_alumno = lector["Codigo_alumno"].ToString(),
                    Codigo_curso = lector["Codigo_curso"].ToString(),
                    Nota40T = Convert.ToSingle(lector["nota40T"]),
                    Nota60L = Convert.ToSingle(lector["nota60L"]),
                    NotaFinal = Convert.ToSingle(lector["notaFinal"])
                };
                listaNotas.Add(nota);
            }
            conexion.CerrarConexion();

            return View(listaNotas);
        }

        // Crear nueva nota
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Nota nuevaNota)
        {
            var comando = new SqlCommand("INSERT INTO notas (Codigo_alumno, Codigo_curso, nota40T, nota60L, notaFinal) " +
                                         "VALUES (@Codigo_alumno, @Codigo_curso, @Nota40T, @Nota60L, @NotaFinal)", conexion.GetConexion());
            comando.Parameters.AddWithValue("@Codigo_alumno", nuevaNota.Codigo_alumno);
            comando.Parameters.AddWithValue("@Codigo_curso", nuevaNota.Codigo_curso);
            comando.Parameters.AddWithValue("@Nota40T", nuevaNota.Nota40T);
            comando.Parameters.AddWithValue("@Nota60L", nuevaNota.Nota60L);
            comando.Parameters.AddWithValue("@NotaFinal", nuevaNota.NotaFinal);

            conexion.AbrirConexion();
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

            return RedirectToAction("Index");
        }

        // Editar nota
        [HttpGet]
        public ActionResult Edit(string Codigo_alumno, string Codigo_curso)
        {
            var comando = new SqlCommand("SELECT * FROM notas WHERE Codigo_alumno = @Codigo_alumno AND Codigo_curso = @Codigo_curso", conexion.GetConexion());
            comando.Parameters.AddWithValue("@Codigo_alumno", Codigo_alumno);
            comando.Parameters.AddWithValue("@Codigo_curso", Codigo_curso);

            conexion.AbrirConexion();
            SqlDataReader lector = comando.ExecuteReader();
            var nota = new Nota();
            if (lector.Read())
            {
                nota.Codigo_alumno = lector["Codigo_alumno"].ToString();
                nota.Codigo_curso = lector["Codigo_curso"].ToString();
                nota.Nota40T = Convert.ToSingle(lector["nota40T"]);
                nota.Nota60L = Convert.ToSingle(lector["nota60L"]);
                nota.NotaFinal = Convert.ToSingle(lector["notaFinal"]);
            }
            conexion.CerrarConexion();

            return View(nota);
        }

        [HttpPost]
        public ActionResult Edit(Nota nota)
        {
            var comando = new SqlCommand("UPDATE notas SET nota40T = @Nota40T, nota60L = @Nota60L, notaFinal = @NotaFinal " +
                                         "WHERE Codigo_alumno = @Codigo_alumno AND Codigo_curso = @Codigo_curso", conexion.GetConexion());
            comando.Parameters.AddWithValue("@Nota40T", nota.Nota40T);
            comando.Parameters.AddWithValue("@Nota60L", nota.Nota60L);
            comando.Parameters.AddWithValue("@NotaFinal", nota.NotaFinal);
            comando.Parameters.AddWithValue("@Codigo_alumno", nota.Codigo_alumno);
            comando.Parameters.AddWithValue("@Codigo_curso", nota.Codigo_curso);

            conexion.AbrirConexion();
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

            return RedirectToAction("Index");
        }

        // Eliminar nota
        public ActionResult Delete(string Codigo_alumno, string Codigo_curso)
        {
            var comando = new SqlCommand("DELETE FROM notas WHERE Codigo_alumno = @Codigo_alumno AND Codigo_curso = @Codigo_curso", conexion.GetConexion());
            comando.Parameters.AddWithValue("@Codigo_alumno", Codigo_alumno);
            comando.Parameters.AddWithValue("@Codigo_curso", Codigo_curso);

            conexion.AbrirConexion();
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

            return RedirectToAction("Index");
        }
    }
}
