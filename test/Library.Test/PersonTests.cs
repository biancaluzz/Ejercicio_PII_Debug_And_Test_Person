using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void TestValidId() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de prueba aquí
            Person person = new Person("Claudia Perez", "5.378.614-6");
            person.ID = "2.004.449-6";
            Assert.AreEqual("2.004.449-6", person.ID);
        }
        [Test]
        public void TestInvalidId() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de prueba aquí
            Person person = new Person("Claudia Perez", "5.378.614-6");
            person.ID = "5.378.614-5";
            Assert.AreEqual("5.378.614-6", person.ID);
        }
        [Test]
        public void TestValidName() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de prueba aquí
            Person person = new Person("Claudia Perez", "6.834.009-2");
            person.Name = "Fernanda Olivera";
            Assert.AreEqual("Fernanda Olivera", person.Name);
        }
        [Test]
        public void TestInvalidName() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de prueba aquí
            Person person = new Person("Claudia Perez", "6.834.009-2");
            person.Name = "";
            Assert.AreEqual("Claudia Perez", person.Name);
        }
        
        
    }
}
