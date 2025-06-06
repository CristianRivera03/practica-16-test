using NUnit.Framework;
using Tienda;

namespace Tienda.test
{
    public class VentaTests
    {
        private Venta _venta;

        [SetUp]
        public void Setup()
        {
            _venta = new Venta();
        }

        [Test]
        public void CalcularTotal_Cantidad2_Precio10_Retorna20()
        {
            double resultado = _venta.CalcularTotal(2, 10);
            Assert.That(resultado, Is.EqualTo(100));
        }

        [Test]
        public void CalcularTotal_Cantidad0_Retorna0()
        {
            double resultado = _venta.CalcularTotal(0, 50);
            Assert.That(resultado, Is.EqualTo(0));
        }

        [Test]
        public void CalcularTotal_CantidadNegativa_LanzaExcepcion()
        {
            Assert.That(() => _venta.CalcularTotal(-1, 10), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void CalcularTotal_PrecioNegativo_LanzaExcepcion()
        {
            Assert.That(() => _venta.CalcularTotal(1, -5), Throws.TypeOf<ArgumentException>());
        }
    }
}
