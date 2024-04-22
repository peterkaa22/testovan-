using System.Runtime.InteropServices.JavaScript;
using System.Xml.Schema;

namespace Test_AdHanz
{
    [TestClass]
    public class fifotest
    {
        [TestMethod]
        public void NoveVytvorenyZasobnikJePrazdny()
        {
             fifo fifo = new fifo();

            Assert.AreEqual(0, fifo.Count(), "Vytvo�en� fifo  pr�zdn�.");
        }
        [TestMethod]
        public void ZasobnikPovlozeniPrvkuNeniPrazdny()
        {
            fifo fifo = new fifo();

            fifo.Push(3);

            Assert.AreNotEqual(0, fifo.Count(), "Vytvo�en� fifo nen� pr�zdn�.");
        }
        [TestMethod]
        public void PocetVlozeniOdpovidaPoctuPrvkuVZasobniku()
        {
            fifo fifo = new fifo();

            fifo.Push(3);
            fifo.Push(5);
            fifo.Push(-8);

            Assert.AreEqual(3, fifo.Count(), "Po�et vlo�en� neodpov�d� po�tu prvk� v Fifo.");
        }

        [TestMethod]
        public void ZasobnikSJednimPrvkemBudePoOdebraniPrvkuPrazdny()
        {
            fifo fifo = new fifo();

            fifo.Push(3);

            Assert.AreEqual(1, fifo.Count());

            fifo.Pop();

            Assert.AreEqual(0, fifo.Count(), "Fifo s jedn�m prvkem nen� po odebr�n� prvku pr�zdn�.");
        }


    }



}
