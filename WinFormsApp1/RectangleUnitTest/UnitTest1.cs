using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp1;

namespace RectangleUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void OverLapTest()
        {
            Form1 frm = new Form1();
            Panel updatePanel = frm.panel1;
            int locX = updatePanel.Location.X;
            int locY = updatePanel.Location.Y;
            frm.adjustLocation(65, 75, updatePanel);

            Assert.AreNotEqual(frm.panel1.Location.X, locX);
            Assert.AreNotEqual(frm.panel1.Location.Y, locY);
        }

        [TestMethod]
        public void RectangleUpdateSize()
        {

            Form1 frm = new Form1();
            
            Panel p1 = frm.panel1;
            int oldW = p1.Width;
            int oldH = p1.Height;

            frm.setPanelSize(220, 125, p1);
            // Assert
            Assert.AreNotEqual(frm.panel1.Width, oldW);
            Assert.AreNotEqual(frm.panel1.Height, oldH);
        }
    }
}
