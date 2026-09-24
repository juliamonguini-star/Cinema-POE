using CinemaDomain;
using System.Diagnostics;
using System.Text.Json;

namespace CinemaTeste
{
    [TestClass]

    public sealed class TestCinemaDomain
    {
        private JsonSerializerOptions OptionsJson()
        {
            return new JsonSerializerOptions { WriteIndented = true };
        }


        [TestMethod]
        public void TestGenero()
        {

            var genero = new Genero { Id = 1, Nome = "Ação" };
            var generoJson = JsonSerializer.Serialize(genero, OptionsJson());
            Debug.WriteLine(generoJson);
            Assert.IsNotNull(generoJson);
        }

        [TestMethod]
        public void TestFilme()
        {
            var genero1 = new Genero { Id = 1, Nome = "Ação" };
            var genero2 = new Genero { Id = 2, Nome = "Suspense" };
            var genero3 = new Genero { Id = 3, Nome = "Romance" };
            var genero4 = new Genero { Id = 4, Nome = "Comédia" };

            var filme1 = new Filme { Id = 1, Nome = "Jurassic Park", Genero = genero1, Classificacao = "14", Duracao = 120 };

            var filmeJson = JsonSerializer.Serialize(filme1, OptionsJson());

            Debug.WriteLine(filmeJson);
            Assert.IsNotNull(filmeJson);
        }

        [TestMethod]
        public void TestIngresso()
        {
            var genero1 = new Genero { Id = 1, Nome = "Ação" };
            var filme1 = new Filme { Id = 1, Nome = "Jurassic Park", Genero = genero1, Classificacao = "14", Duracao = 120 };
            var sala1 = new Sala { Id = 1, Numero = 1, Fileira = 1, Assentos = 1, Capacidade = 100 };
            var sessao = new Sessao { Data = new DateTime(2026, 12, 10), Preco = 20.0m, Sala = sala1, Filme = filme1 };

            

            var ingresso = new Ingresso
            {
                Documento = "12345678900",
                Sessao = sessao,
                DataCompra = DateTime.Now,
                FormaPagamento = "Cartão",
                IngressoItens = new List<IngressoItem>(),
                ValorTotal = 20.0m
            };
            var ingressoJson = JsonSerializer.Serialize(ingresso, OptionsJson());
            Debug.WriteLine(ingressoJson);
            Assert.IsNotNull(ingressoJson);
        }

        [TestMethod]
        public void TestIngressoItem()
        {
            var ingressoItem = new IngressoItem
            {
                Assento = 5,
                Fileira = 3,
                MeiaEntrada = true
            };

            var itemJson = JsonSerializer.Serialize(ingressoItem, OptionsJson());
            Debug.WriteLine(itemJson);
            Assert.IsNotNull(itemJson);

        }

        [TestMethod]
        public void TestSala()
        {
            var sala1 = new Sala { Id = 1, Numero = 1, Fileira = 1, Assentos = 1, Capacidade = 100 };
            var salaJson = JsonSerializer.Serialize(sala1, OptionsJson());
            Debug.WriteLine(salaJson);
            Assert.IsNotNull(salaJson);
        }

        [TestMethod]
        public void TestSessao()
        {
            var genero1 = new Genero { Id = 1, Nome = "Ação" };
            var filme1 = new Filme { Id = 1, Nome = "Jurassic Park", Genero = genero1, Classificacao = "14", Duracao = 120 };
            var sala1 = new Sala { Id = 1, Numero = 1, Fileira = 1, Assentos = 1, Capacidade = 100 };

            var sessao = new Sessao { Id = 1, Data = new DateTime(2026, 12, 10), Preco = 20.0m, Sala = sala1, Filme = filme1 };

            var sessaoJson = JsonSerializer.Serialize(sessao, OptionsJson());
            Debug.WriteLine(sessaoJson);
            Assert.IsNotNull(sessaoJson);
        }
    }
}